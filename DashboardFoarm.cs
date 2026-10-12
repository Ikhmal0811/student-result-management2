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
    public partial class DashboardFoarm : Form
    {
        private string query = "SELECT CONCAT('STD', LPAD(studentID, 3, '0')) AS 'Student ID', stdname AS 'Student Name', email AS 'Email' FROM students";

        private MySqlDataAdapter adapter;

        private DataTable dataTable = new DataTable();
        public DashboardFoarm()
        {
            InitializeComponent();
        }

        private void DashboardFoarm_Load(object sender, EventArgs e)
        {
            LoadDataIntroGrid();
        }

        private void LoadDataIntroGrid()
        {


            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    adapter.Fill(dataTable);

                    this.dataGridView1.DataSource = dataTable;

                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string searchText = txtSearch.Text.Trim().Replace("'", "''"); // Escape single quotes

                // Filter across multiple columns (Student ID, Student Name, or Email)
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = string.Format("[Student ID] LIKE '%{0}%' OR [Student Name] LIKE '%{0}%' OR [Email] LIKE '%{0}%'", searchText);

                dataGridView1.DataSource = dv;
            }
        }
    }
}