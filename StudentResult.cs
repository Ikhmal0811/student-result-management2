using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectAP231
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //validation
            if (stdCombo.SelectedIndex == -1 || cmbCourse.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = Convert.ToInt32(stdCombo.SelectedValue);
            int courseID = Convert.ToInt32(cmbCourse.SelectedValue);
            string grade = txtGrade.Text.Trim();
            string score = textBox1.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Check if result already exists (Fixed table name to student_result and used courseID)
                    string checkQuery = "SELECT COUNT(*) FROM results WHERE studentID = @studentID AND courseID = @courseID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@studentID", studentID);
                        checkCmd.Parameters.AddWithValue("@courseID", courseID);

                        long existingCount = (long)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            // Prompt user if they want to update
                            DialogResult dialogResult = MessageBox.Show(
                                "A result for this student and course already exists. Do you want to update it?",
                                "Record Exists",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.No) return;

                            // 2. Update existing record (Fixed to use courseID instead of courseCode)
                            string updateQuery = "UPDATE results SET score = @score, grade = @grade WHERE studentID = @studentID AND courseID = @courseID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@score", score);
                                updateCmd.Parameters.AddWithValue("@grade", grade);
                                updateCmd.Parameters.AddWithValue("@studentID", studentID);
                                updateCmd.Parameters.AddWithValue("@courseID", courseID);

                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Result for " + studentID + " updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                                return;
                            }
                        }
                    }

                    // 3. Insert new record (Fixed to use courseID instead of courseCode)
                    string insertQuery = "INSERT INTO results (studentID, courseID, score, grade) VALUES (@studentID, @courseID, @score, @grade)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@studentID", studentID);
                        insertCmd.Parameters.AddWithValue("@courseID", courseID);
                        insertCmd.Parameters.AddWithValue("@score", score);
                        insertCmd.Parameters.AddWithValue("@grade", grade);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Result saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            stdCombo.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            textBox1.Clear();
            txtGrade.Clear();
            stdCombo.Focus();
        }




        private void StudentResult_Load(object sender, EventArgs e)
        {
            LoadStudentsComboBox();
            LoadCourseComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stdCombo.SelectedIndex == -1 || stdCombo.SelectedValue == null)
            {
                dataGridView1.DataSource = null; // Clear grid if no student is selected
                return;
            }

            // Get the selected student ID
            if (int.TryParse(stdCombo.SelectedValue.ToString(), out int studentID))
            {
                LoadResultsForStudent(studentID);
            }
        }

        private void LoadStudentsComboBox()
        {
            string query = "SELECT studentID, stdname FROM students";
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    stdCombo.DataSource = dt;
                    stdCombo.DisplayMember = "stdname"; // What the user sees
                    stdCombo.ValueMember = "studentID";   // Hidden ID
                    stdCombo.SelectedIndex = -1;         // Starts blank
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

        private void LoadCourseComboBox()
        {
            string query = "SELECT courseID, courseCode FROM course";
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCourse.DataSource = dt;
                    cmbCourse.DisplayMember = "courseCode"; // What the user sees
                    cmbCourse.ValueMember = "courseID";   // Hidden ID
                    cmbCourse.SelectedIndex = -1;         // Starts blank
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal result))
            {
                txtGrade.Text = CalculateGrade(result);
            }
        }

        private string CalculateGrade(decimal score)
        {
            if (score >= 75 && score <= 100) return "A";
            else if (score >= 60 && score < 75) return "B";
            else if (score >= 50 && score < 60) return "C";
            else if (score >= 40 && score < 50) return "D";
            else if (score >= 0 && score < 40) return "F";
            else return "Invalid Score";
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void LoadResultsForStudent(int studentID)
        {
            string query = @"SELECT c.courseCode AS 'Course Code', 
                            c.courseName AS 'Course Name', 
                            sr.score AS 'Score', 
                            sr.grade AS 'Grade' 
                     FROM results sr
                     JOIN course c ON sr.courseID = c.courseID
                     WHERE sr.studentID = @studentID";

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.ReadOnly = true; // Make it view-only
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student results: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
