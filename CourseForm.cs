using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace projectAP231
{
    public partial class CourseForm : Form
    {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder commandBuilder;
        private DataTable dataTable = new DataTable();
        string query = "SELECT courseID, courseCode, courseName FROM course";

        public CourseForm()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO course (courseCode, courseName) Values (@courseCode, @courseName);";
            string courseCode = txtCCode.Text.Trim();
            string courseName = txtCName.Text.Trim();

            //validation

            if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseCode", courseCode);
                        cmd.Parameters.AddWithValue("@courseName", courseName);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCCode.Clear();
                            txtCName.Clear();

                            LoadDataIntoGrid(); // Refresh the DataGridView to show the newly added course
                        }
                        else
                        {
                            MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void LoadDataIntoGrid()
        {

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter(query, conn);
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    dataTable = new DataTable();

                    dataTable.Clear(); // Clear existing data before filling
                    adapter.Fill(dataTable);


                    this.dataGridView1.DataSource = dataTable;
                    this.dataGridView1.ReadOnly = false; // Allow editing

                    if (this.dataGridView1.Columns.Contains("courseID"))
                    {
                        this.dataGridView1.Columns["courseID"].Visible = false; // Hide the ID column
                    }

                    if (this.dataGridView1.Columns.Contains("courseCode"))
                    {
                        this.dataGridView1.Columns["courseCode"].HeaderText = "Course Code";
                    }

                    if (this.dataGridView1.Columns.Contains("courseName"))
                    {
                        this.dataGridView1.Columns["courseName"].HeaderText = "Course Name";
                    }

                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.EndEdit(); // End any ongoing edits

                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    int updatedCount = 0;

                    // Loop through the DataTable rows to find modified ones
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            int courseID = Convert.ToInt32(row["courseID"]);
                            string courseCode = row["courseCode"].ToString();
                            string courseName = row["courseName"].ToString();

                            string updateQuery = "UPDATE course SET courseCode = @courseCode, courseName = @courseName WHERE courseID = @courseID";

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@courseCode", courseCode);
                                cmd.Parameters.AddWithValue("@courseName", courseName);
                                cmd.Parameters.AddWithValue("@courseID", courseID);

                                cmd.ExecuteNonQuery();
                                updatedCount++;
                            }
                        }
                    }

                    // Clear the modified state flag in the DataTable
                    dataTable.AcceptChanges();

                    MessageBox.Show($"{updatedCount} row(s) updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid
                    LoadDataIntoGrid();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDltC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Please select a course to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows[rowIndex].Cells["courseID"].Value == null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int courseID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["courseID"].Value);
            string courseCode = dataGridView1.Rows[rowIndex].Cells["courseCode"].Value?.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete course '{courseCode}'?",
                                           "Confirm Deletion",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM course WHERE courseID = @courseID;";

                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@courseID", courseID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataIntoGrid(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
