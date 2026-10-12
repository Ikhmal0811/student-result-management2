using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.Windows.Forms;

namespace projectAP231
{
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();

            // ------------------------------------------- Test database connection  --------------------------------------
            //using (MySqlConnection conn = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        conn.Open();
            //        MessageBox.Show("Database Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch(MySqlException ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }





        // to make gradient background for the form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color topColor = Color.FromArgb(17, 102, 209);
            Color bottomColor = Color.FromArgb(183, 207, 252);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                topColor,
                bottomColor,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            //validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }


            if (username.StartsWith("ADM", StringComparison.OrdinalIgnoreCase))
            {


                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string numericPart = username.Substring(3);
                        if (int.TryParse(numericPart, out int adminID))
                        {

                            string adminQuery = "SELECT adminID, admName From admins WHERE adminID = @adminID AND password = @password";

                            using (MySqlCommand adminCmd = new MySqlCommand(adminQuery, conn))
                            {
                                adminCmd.Parameters.AddWithValue("@adminID", adminID);
                                adminCmd.Parameters.AddWithValue("@password", password);

                                using (MySqlDataReader adminReader = adminCmd.ExecuteReader())
                                {
                                    if (adminReader.Read())
                                    {
                                        string adminName = adminReader["admName"].ToString();
                                        MessageBox.Show($"Welcome Admin, {adminName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        MainForm mainForm = new MainForm();

                                        mainForm.Show();
                                        this.Hide();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Username or Password. Pleas Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database or System Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }






            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}
