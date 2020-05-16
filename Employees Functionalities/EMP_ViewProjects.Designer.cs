namespace Housing_Database_Project.Employees_Functionalities
{
    partial class EMP_ViewProjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Projects = new System.Windows.Forms.DataGridView();
            this.button_ViewProj = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.newStatus = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Projects";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_City);
            this.groupBox1.Controls.Add(this.comboBox_Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(306, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(538, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(331, 44);
            this.comboBox_City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(152, 28);
            this.comboBox_City.TabIndex = 7;
            this.comboBox_City.SelectedIndexChanged += new System.EventHandler(this.comboBox_City_SelectedIndexChanged);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "All",
            "Posted",
            "Started",
            "Launched",
            "All Units Sold"});
            this.comboBox_Status.Location = new System.Drawing.Point(75, 44);
            this.comboBox_Status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(152, 28);
            this.comboBox_Status.TabIndex = 6;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // dataGridView_Projects
            // 
            this.dataGridView_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Projects.Location = new System.Drawing.Point(14, 211);
            this.dataGridView_Projects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Projects.Name = "dataGridView_Projects";
            this.dataGridView_Projects.RowHeadersWidth = 51;
            this.dataGridView_Projects.RowTemplate.Height = 24;
            this.dataGridView_Projects.Size = new System.Drawing.Size(1110, 410);
            this.dataGridView_Projects.TabIndex = 4;
            // 
            // button_ViewProj
            // 
            this.button_ViewProj.Location = new System.Drawing.Point(915, 125);
            this.button_ViewProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ViewProj.Name = "button_ViewProj";
            this.button_ViewProj.Size = new System.Drawing.Size(144, 35);
            this.button_ViewProj.TabIndex = 5;
            this.button_ViewProj.Text = "Project Details";
            this.button_ViewProj.UseVisualStyleBackColor = true;
            this.button_ViewProj.Click += new System.EventHandler(this.button_ViewProj_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(915, 74);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(144, 35);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(915, 31);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(144, 35);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // newStatus
            // 
            this.newStatus.FormattingEnabled = true;
            this.newStatus.Items.AddRange(new object[] {
            "Posted",
            "Started",
            "Launched",
            "All Units Sold"});
            this.newStatus.Location = new System.Drawing.Point(124, 57);
            this.newStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newStatus.Name = "newStatus";
            this.newStatus.Size = new System.Drawing.Size(152, 28);
            this.newStatus.TabIndex = 9;
            this.newStatus.SelectedIndexChanged += new System.EventHandler(this.newStatus_SelectedIndexChanged);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(23, 60);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(95, 20);
            this.StatusText.TabIndex = 8;
            this.StatusText.Text = "New Status:";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(124, 143);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(144, 35);
            this.Confirm.TabIndex = 10;
            this.Confirm.Text = "Confirm Status";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Change Status:";
            // 
            // Company
            // 
            this.Company.FormattingEnabled = true;
            this.Company.Items.AddRange(new object[] {
            "Posted",
            "Started",
            "Launched",
            "All Units Sold"});
            this.Company.Location = new System.Drawing.Point(124, 93);
            this.Company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(152, 28);
            this.Company.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Assign to: ";
            // 
            // EMP_ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 636);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.newStatus);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button_ViewProj);
            this.Controls.Add(this.dataGridView_Projects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EMP_ViewProjects";
            this.Text = "PEMP_ViewProjects";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PEMP_ViewProjects_FormClosed);
            this.Load += new System.EventHandler(this.PEMP_ViewProjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Projects;
        private System.Windows.Forms.Button button_ViewProj;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox newStatus;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Company;
        private System.Windows.Forms.Label label5;
    }
}