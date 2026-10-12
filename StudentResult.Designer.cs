namespace projectAP231
{
    partial class StudentResult
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
            lblStud = new Label();
            btnAddResult = new Button();
            lblCourse = new Label();
            lblGrade = new Label();
            lblScore = new Label();
            stdCombo = new ComboBox();
            cmbCourse = new ComboBox();
            textBox1 = new TextBox();
            txtGrade = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblStud
            // 
            lblStud.AutoSize = true;
            lblStud.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStud.Location = new Point(102, 58);
            lblStud.Name = "lblStud";
            lblStud.Size = new Size(96, 17);
            lblStud.TabIndex = 0;
            lblStud.Text = "Student Name";
            // 
            // btnAddResult
            // 
            btnAddResult.BackColor = SystemColors.MenuHighlight;
            btnAddResult.Cursor = Cursors.Hand;
            btnAddResult.FlatAppearance.BorderSize = 0;
            btnAddResult.FlatStyle = FlatStyle.Flat;
            btnAddResult.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddResult.ForeColor = Color.White;
            btnAddResult.Location = new Point(102, 175);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(136, 28);
            btnAddResult.TabIndex = 1;
            btnAddResult.Text = "Save Result";
            btnAddResult.UseVisualStyleBackColor = false;
            btnAddResult.Click += btnAddCourse_Click;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(369, 58);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(50, 17);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Course";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(220, 119);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(44, 17);
            lblGrade.TabIndex = 3;
            lblGrade.Text = "Grade";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblScore.Location = new Point(103, 119);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(44, 19);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score";
            lblScore.Click += lblScore_Click;
            // 
            // stdCombo
            // 
            stdCombo.Font = new Font("Segoe UI", 12F);
            stdCombo.FormattingEnabled = true;
            stdCombo.Location = new Point(102, 76);
            stdCombo.Name = "stdCombo";
            stdCombo.Size = new Size(246, 29);
            stdCombo.TabIndex = 6;
            stdCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 12F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(369, 76);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(246, 29);
            cmbCourse.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(220, 137);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 150);
            dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(103, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 23;
            label2.Text = "Student Result";
            // 
            // StudentResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 482);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtGrade);
            Controls.Add(textBox1);
            Controls.Add(cmbCourse);
            Controls.Add(stdCombo);
            Controls.Add(lblScore);
            Controls.Add(lblGrade);
            Controls.Add(lblCourse);
            Controls.Add(btnAddResult);
            Controls.Add(lblStud);
            ForeColor = SystemColors.ControlText;
            Name = "StudentResult";
            Text = "StudentResult";
            Load += StudentResult_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStud;
        private Button btnAddResult;
        private Label lblCourse;
        private Label lblGrade;
        private Label lblScore;
        private ComboBox stdCombo;
        private ComboBox cmbCourse;
        private TextBox textBox1;
        private TextBox txtGrade;
        private DataGridView dataGridView1;
        private Label label2;
    }
}