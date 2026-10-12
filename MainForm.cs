using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectAP231
{
    public partial class MainForm : Form
    {
        private Form activeForm = new DashboardFoarm();

        private RegisterForm registerFormInstance = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            // Close current child form if one is already open
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = childForm;

            // Strip window borders so it fits smoothly into panelContent
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Clear old controls and display the new form
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LoadFormIntoPanel(new RegStudForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new DashboardFoarm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new StudentResult());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new DashboardFoarm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new CourseForm());
        }
    }
}
