namespace Housing_Database_Project.Employees_Functionalities
{
    partial class PEMP_ViewTrans
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
            this.dataGridView_Trans = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.comboBox_Bank = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_NoFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company Transactions";
            // 
            // dataGridView_Trans
            // 
            this.dataGridView_Trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Trans.Location = new System.Drawing.Point(12, 151);
            this.dataGridView_Trans.Name = "dataGridView_Trans";
            this.dataGridView_Trans.RowHeadersWidth = 51;
            this.dataGridView_Trans.RowTemplate.Height = 24;
            this.dataGridView_Trans.Size = new System.Drawing.Size(987, 322);
            this.dataGridView_Trans.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Company);
            this.groupBox1.Controls.Add(this.comboBox_Bank);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(258, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(307, 35);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Company.TabIndex = 7;
            this.comboBox_Company.SelectedIndexChanged += new System.EventHandler(this.comboBox_Company_SelectedIndexChanged);
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Items.AddRange(new object[] {
            "All",
            "Waiting",
            "Accepted",
            "Rejected",
            "Done"});
            this.comboBox_Bank.Location = new System.Drawing.Point(67, 35);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Bank.TabIndex = 6;
            this.comboBox_Bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bank_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bank";
            // 
            // button_NoFilter
            // 
            this.button_NoFilter.Location = new System.Drawing.Point(802, 66);
            this.button_NoFilter.Name = "button_NoFilter";
            this.button_NoFilter.Size = new System.Drawing.Size(142, 34);
            this.button_NoFilter.TabIndex = 10;
            this.button_NoFilter.Text = "Remove Filters";
            this.button_NoFilter.UseVisualStyleBackColor = true;
            this.button_NoFilter.Click += new System.EventHandler(this.button_NoFilter_Click);
            // 
            // PEMP_ViewTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.button_NoFilter);
            this.Controls.Add(this.dataGridView_Trans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PEMP_ViewTrans";
            this.Text = "S";
            this.Load += new System.EventHandler(this.PEMP_ViewTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Trans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.ComboBox comboBox_Bank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_NoFilter;
    }
}