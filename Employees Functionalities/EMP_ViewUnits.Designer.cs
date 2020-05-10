namespace Housing_Database_Project.Employees_Functionalities
{
    partial class EMP_ViewUnits
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
            this.dataGridView_Units = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Project = new System.Windows.Forms.ComboBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Units)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Units
            // 
            this.dataGridView_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Units.Location = new System.Drawing.Point(12, 176);
            this.dataGridView_Units.Name = "dataGridView_Units";
            this.dataGridView_Units.RowHeadersWidth = 51;
            this.dataGridView_Units.RowTemplate.Height = 24;
            this.dataGridView_Units.Size = new System.Drawing.Size(987, 322);
            this.dataGridView_Units.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Project);
            this.groupBox1.Controls.Add(this.comboBox_Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(272, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_Project
            // 
            this.comboBox_Project.FormattingEnabled = true;
            this.comboBox_Project.Location = new System.Drawing.Point(294, 35);
            this.comboBox_Project.Name = "comboBox_Project";
            this.comboBox_Project.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Project.TabIndex = 7;
            this.comboBox_Project.SelectedIndexChanged += new System.EventHandler(this.comboBox_Project_SelectedIndexChanged);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "All",
            "Sold",
            "Not Sold"});
            this.comboBox_Status.Location = new System.Drawing.Point(67, 35);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Status.TabIndex = 6;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Units";
            // 
            // EMP_ViewUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.dataGridView_Units);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EMP_ViewUnits";
            this.Text = "EMP_ViewUnits";
            this.Load += new System.EventHandler(this.EMP_ViewUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Units)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Units;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Project;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}