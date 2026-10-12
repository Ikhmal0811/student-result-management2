namespace projectAP231
{
    partial class RegStudForm
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
            btnRegStudent = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblPass = new Label();
            labelEmail = new Label();
            lblDob = new Label();
            lblName = new Label();
            txtConfirmPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegStudent
            // 
            btnRegStudent.BackColor = SystemColors.MenuHighlight;
            btnRegStudent.Cursor = Cursors.Hand;
            btnRegStudent.FlatAppearance.BorderSize = 0;
            btnRegStudent.FlatStyle = FlatStyle.Flat;
            btnRegStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegStudent.ForeColor = SystemColors.ButtonHighlight;
            btnRegStudent.Location = new Point(29, 371);
            btnRegStudent.Name = "btnRegStudent";
            btnRegStudent.Size = new Size(143, 45);
            btnRegStudent.TabIndex = 1;
            btnRegStudent.Text = "Register Student";
            btnRegStudent.UseVisualStyleBackColor = false;
            btnRegStudent.Click += btnRegStudent_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveCaption;
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(29, 287);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 29);
            dateTimePicker1.TabIndex = 19;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPass.Location = new Point(29, 215);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(274, 29);
            txtPass.TabIndex = 17;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(29, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 29);
            txtEmail.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtName.Location = new Point(29, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 29);
            txtName.TabIndex = 15;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPass.Location = new Point(29, 193);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(68, 19);
            lblPass.TabIndex = 14;
            lblPass.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEmail.Location = new Point(29, 125);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 19);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDob.Location = new Point(29, 265);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(89, 19);
            lblDob.TabIndex = 12;
            lblDob.Text = "Date of Birth";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblName.Location = new Point(29, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 19);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.White;
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtConfirmPass.Location = new Point(368, 215);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(274, 29);
            txtConfirmPass.TabIndex = 21;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(368, 193);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 20;
            label1.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 22;
            label2.Text = "New Student";
            // 
            // RegStudForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(817, 568);
            Controls.Add(label2);
            Controls.Add(txtConfirmPass);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPass);
            Controls.Add(labelEmail);
            Controls.Add(lblDob);
            Controls.Add(lblName);
            Controls.Add(btnRegStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegStudForm";
            Text = "RegStudForm";
            Load += RegStudForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegStudent;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblPass;
        private Label labelEmail;
        private Label lblDob;
        private Label lblName;
        private TextBox txtConfirmPass;
        private Label label1;
        private Label label2;
    }
}