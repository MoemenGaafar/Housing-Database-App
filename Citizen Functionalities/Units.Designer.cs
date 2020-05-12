namespace Housing_Database_Project
{
    partial class Units
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelUnit = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.ProjectApply = new System.Windows.Forms.ComboBox();
            this.ProjectSort = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.MaxApplications = new System.Windows.Forms.Label();
            this.Manage = new System.Windows.Forms.Button();
            this.YourApplications = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(831, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Units:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apply:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Project";
            // 
            // LabelUnit
            // 
            this.LabelUnit.AutoSize = true;
            this.LabelUnit.Location = new System.Drawing.Point(341, 460);
            this.LabelUnit.Name = "LabelUnit";
            this.LabelUnit.Size = new System.Drawing.Size(42, 20);
            this.LabelUnit.TabIndex = 6;
            this.LabelUnit.Text = "Unit:";
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            this.Unit.Location = new System.Drawing.Point(409, 457);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(121, 28);
            this.Unit.TabIndex = 7;
            // 
            // ProjectApply
            // 
            this.ProjectApply.FormattingEnabled = true;
            this.ProjectApply.Location = new System.Drawing.Point(105, 460);
            this.ProjectApply.Name = "ProjectApply";
            this.ProjectApply.Size = new System.Drawing.Size(121, 28);
            this.ProjectApply.TabIndex = 8;
            this.ProjectApply.SelectedIndexChanged += new System.EventHandler(this.ProjectApply_SelectedIndexChanged);
            // 
            // ProjectSort
            // 
            this.ProjectSort.FormattingEnabled = true;
            this.ProjectSort.Location = new System.Drawing.Point(105, 81);
            this.ProjectSort.Name = "ProjectSort";
            this.ProjectSort.Size = new System.Drawing.Size(121, 28);
            this.ProjectSort.TabIndex = 9;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(366, 81);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(122, 26);
            this.Price.TabIndex = 10;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(504, 81);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(108, 30);
            this.View.TabIndex = 11;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(585, 505);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(108, 30);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MaxApplications
            // 
            this.MaxApplications.AutoSize = true;
            this.MaxApplications.Location = new System.Drawing.Point(101, 387);
            this.MaxApplications.Name = "MaxApplications";
            this.MaxApplications.Size = new System.Drawing.Size(19, 20);
            this.MaxApplications.TabIndex = 13;
            this.MaxApplications.Text = "()";
            // 
            // Manage
            // 
            this.Manage.Location = new System.Drawing.Point(374, 505);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(189, 34);
            this.Manage.TabIndex = 14;
            this.Manage.Text = "Manage Applications";
            this.Manage.UseVisualStyleBackColor = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // YourApplications
            // 
            this.YourApplications.AutoSize = true;
            this.YourApplications.Location = new System.Drawing.Point(101, 418);
            this.YourApplications.Name = "YourApplications";
            this.YourApplications.Size = new System.Drawing.Size(19, 20);
            this.YourApplications.TabIndex = 15;
            this.YourApplications.Text = "()";
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(105, 47);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 28);
            this.City.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "City:";
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(248, 45);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(108, 30);
            this.Filter.TabIndex = 18;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 548);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YourApplications);
            this.Controls.Add(this.Manage);
            this.Controls.Add(this.MaxApplications);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProjectSort);
            this.Controls.Add(this.ProjectApply);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.LabelUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Units";
            this.Text = "Units";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Units_FormClosed);
            this.Load += new System.EventHandler(this.Units_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelUnit;
        private System.Windows.Forms.ComboBox Unit;
        private System.Windows.Forms.ComboBox ProjectApply;
        private System.Windows.Forms.ComboBox ProjectSort;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label MaxApplications;
        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.Label YourApplications;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Filter;
    }
}