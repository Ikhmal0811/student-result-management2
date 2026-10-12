namespace projectAP231
{
    partial class RegisterForm
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
            lblName = new Label();
            lblDob = new Label();
            labelEmail = new Label();
            lblPass = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnRgstr = new Button();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(121, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(121, 127);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(73, 15);
            lblDob.TabIndex = 1;
            lblDob.Text = "Date of Birth";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(424, 75);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(424, 127);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(121, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 29);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(424, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 29);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(424, 145);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(200, 23);
            txtPass.TabIndex = 7;
            // 
            // btnRgstr
            // 
            btnRgstr.BackColor = SystemColors.MenuHighlight;
            btnRgstr.Cursor = Cursors.Hand;
            btnRgstr.FlatAppearance.BorderSize = 0;
            btnRgstr.FlatStyle = FlatStyle.Flat;
            btnRgstr.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRgstr.ForeColor = Color.White;
            btnRgstr.Location = new Point(206, 254);
            btnRgstr.Name = "btnRgstr";
            btnRgstr.Size = new Size(99, 41);
            btnRgstr.TabIndex = 8;
            btnRgstr.Text = "Register";
            btnRgstr.UseVisualStyleBackColor = false;
            btnRgstr.Click += btnRgstr_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(121, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(408, 254);
            button1.Name = "button1";
            button1.Size = new Size(99, 41);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnRgstr);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPass);
            Controls.Add(labelEmail);
            Controls.Add(lblDob);
            Controls.Add(lblName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDob;
        private Label labelEmail;
        private Label lblPass;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnRgstr;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}