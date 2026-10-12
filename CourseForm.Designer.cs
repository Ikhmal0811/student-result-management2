namespace projectAP231
{
    partial class CourseForm
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
            btnAddCourse = new Button();
            txtCName = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            txtCCode = new TextBox();
            lblCourseName = new Label();
            lblCourseCode = new Label();
            btnUpdateC = new Button();
            btnDltC = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = SystemColors.MenuHighlight;
            btnAddCourse.Cursor = Cursors.Hand;
            btnAddCourse.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddCourse.ForeColor = Color.Transparent;
            btnAddCourse.Location = new Point(39, 115);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(92, 30);
            btnAddCourse.TabIndex = 0;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // txtCName
            // 
            txtCName.BorderStyle = BorderStyle.FixedSingle;
            txtCName.Font = new Font("Segoe UI", 12F);
            txtCName.Location = new Point(39, 70);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(188, 29);
            txtCName.TabIndex = 1;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // txtCCode
            // 
            txtCCode.BorderStyle = BorderStyle.FixedSingle;
            txtCCode.Font = new Font("Segoe UI", 12F);
            txtCCode.Location = new Point(278, 70);
            txtCCode.Name = "txtCCode";
            txtCCode.Size = new Size(188, 29);
            txtCCode.TabIndex = 2;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(39, 52);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(82, 15);
            lblCourseName.TabIndex = 3;
            lblCourseName.Text = "Course Name ";
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Location = new Point(278, 52);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(78, 15);
            lblCourseCode.TabIndex = 4;
            lblCourseCode.Text = "Course Code ";
            // 
            // btnUpdateC
            // 
            btnUpdateC.BackColor = SystemColors.MenuHighlight;
            btnUpdateC.Cursor = Cursors.Hand;
            btnUpdateC.FlatAppearance.BorderSize = 0;
            btnUpdateC.FlatStyle = FlatStyle.Flat;
            btnUpdateC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateC.ForeColor = Color.Transparent;
            btnUpdateC.Location = new Point(39, 389);
            btnUpdateC.Name = "btnUpdateC";
            btnUpdateC.Size = new Size(108, 36);
            btnUpdateC.TabIndex = 5;
            btnUpdateC.Text = "Update Course";
            btnUpdateC.UseVisualStyleBackColor = false;
            btnUpdateC.Click += btnUpdateC_Click;
            // 
            // btnDltC
            // 
            btnDltC.BackColor = SystemColors.MenuHighlight;
            btnDltC.Cursor = Cursors.Hand;
            btnDltC.FlatAppearance.BorderSize = 0;
            btnDltC.FlatStyle = FlatStyle.Flat;
            btnDltC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDltC.ForeColor = Color.Transparent;
            btnDltC.Location = new Point(163, 389);
            btnDltC.Name = "btnDltC";
            btnDltC.Size = new Size(103, 36);
            btnDltC.TabIndex = 6;
            btnDltC.Text = "Delete Course";
            btnDltC.UseVisualStyleBackColor = false;
            btnDltC.Click += btnDltC_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(510, 206);
            dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(39, 9);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 23;
            label2.Text = "Courses";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(686, 453);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnDltC);
            Controls.Add(btnUpdateC);
            Controls.Add(lblCourseCode);
            Controls.Add(lblCourseName);
            Controls.Add(txtCCode);
            Controls.Add(txtCName);
            Controls.Add(btnAddCourse);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCourse;
        private TextBox txtCName;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TextBox txtCCode;
        private Label lblCourseName;
        private Label lblCourseCode;
        private Button btnUpdateC;
        private Button btnDltC;
        private DataGridView dataGridView1;
        private Label label2;
    }
}