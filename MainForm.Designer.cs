namespace projectAP231
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelNav = new Panel();
            btnCourse = new Button();
            btnStdRslt = new Button();
            btnLogout = new Button();
            btnRegStud = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = SystemColors.ActiveCaption;
            panelNav.Controls.Add(btnStdRslt);
            panelNav.Controls.Add(btnCourse);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnRegStud);
            panelNav.Controls.Add(button1);
            panelNav.Controls.Add(pictureBox1);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(184, 576);
            panelNav.TabIndex = 0;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = SystemColors.ActiveCaption;
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.Dock = DockStyle.Top;
            btnCourse.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourse.Location = new Point(0, 188);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(184, 46);
            btnCourse.TabIndex = 5;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = false;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnStdRslt
            // 
            btnStdRslt.BackColor = SystemColors.ActiveCaption;
            btnStdRslt.Cursor = Cursors.Hand;
            btnStdRslt.Dock = DockStyle.Top;
            btnStdRslt.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnStdRslt.FlatStyle = FlatStyle.Flat;
            btnStdRslt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdRslt.Location = new Point(0, 234);
            btnStdRslt.Name = "btnStdRslt";
            btnStdRslt.Size = new Size(184, 46);
            btnStdRslt.TabIndex = 3;
            btnStdRslt.Text = "Students Result";
            btnStdRslt.UseVisualStyleBackColor = false;
            btnStdRslt.Click += button3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 46);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRegStud
            // 
            btnRegStud.BackColor = SystemColors.ActiveCaption;
            btnRegStud.Cursor = Cursors.Hand;
            btnRegStud.Dock = DockStyle.Top;
            btnRegStud.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnRegStud.FlatStyle = FlatStyle.Flat;
            btnRegStud.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegStud.Location = new Point(0, 142);
            btnRegStud.Name = "btnRegStud";
            btnRegStud.Size = new Size(184, 46);
            btnRegStud.TabIndex = 2;
            btnRegStud.Text = "Register Student";
            btnRegStud.UseVisualStyleBackColor = false;
            btnRegStud.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 96);
            button1.Name = "button1";
            button1.Size = new Size(184, 46);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(184, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(894, 576);
            panelContent.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 576);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Panel panelContent;
        private Button btnLogout;
        private Button btnStdRslt;
        private Button btnRegStud;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnCourse;
    }
}