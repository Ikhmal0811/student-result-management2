namespace projectAP231
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            labelUsername = new Label();
            lblPass = new Label();
            btnLogin = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(31, 132);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(337, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(31, 233);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(337, 33);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUsername.Location = new Point(31, 110);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(71, 19);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPass.Location = new Point(31, 211);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(68, 19);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(16, 42, 77);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(31, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(248, 249, 250);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 216);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(16, 42, 77);
            button1.Location = new Point(206, 345);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 5;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 55);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 6;
            label1.Text = "WELCOME ACADEMY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 437);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(lblPass);
            Controls.Add(labelUsername);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label labelUsername;
        private Label lblPass;
        private Button btnLogin;
        private Button button1;
        private Label label1;
    }
}
