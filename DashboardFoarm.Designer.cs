namespace projectAP231
{
    partial class DashboardFoarm
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
            dataGridView1 = new DataGridView();
            lblStudentList = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(705, 304);
            dataGridView1.TabIndex = 1;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentList.Location = new Point(50, 33);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(125, 30);
            lblStudentList.TabIndex = 2;
            lblStudentList.Text = "Student List";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(202, 412);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 414);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 4;
            label1.Text = "Search Student:";
            // 
            // DashboardFoarm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(927, 502);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(lblStudentList);
            Controls.Add(dataGridView1);
            Name = "DashboardFoarm";
            Text = "DashboardFoarm";
            Load += DashboardFoarm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblStudentList;
        private TextBox txtSearch;
        private Label label1;
    }
}