using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projectAP231
{
    public partial class RegStudForm : Form
    {
        public RegStudForm()
        {
            InitializeComponent();
        }

        private void RegStudForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegStudent_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO students (stdname, dob, email, password) Values (@stdname, @dob, @email, @password);SELECT LAST_INSERT_ID();";
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirmPassword = txtConfirmPass.Text.Trim();
            DateTime selectDate = dateTimePicker1.Value;


            //validation
            if(password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Clear();
                txtConfirmPass.Clear();
                txtPass.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address (e.g., user@example.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }



            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@stdname", name);
                        cmd.Parameters.AddWithValue("@dob", selectDate);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int newStudentID = Convert.ToInt32(cmd.ExecuteScalar());

                        string customStudentID = "STD" + newStudentID.ToString("D3"); // Format as STD001, STD002, etc.
                        MessageBox.Show($"Student registered successfully! Student ID: {customStudentID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            txtEmail.Clear();
            txtName.Clear();    
            txtPass.Clear();
            txtConfirmPass.Clear();
        }

            private bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                // 1. Standard Regex check for structure (user@domain.com)
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                    return false;

                // 2. Strict MailAddress parsing check
                try
                {
                    var mail = new MailAddress(email);
                    return mail.Address == email;
                }
                catch
                {
                    return false;
                }

        

            }
    }
}       
