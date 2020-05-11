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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(703, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apply:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Project";
            // 
            // LabelUnit
            // 
            this.LabelUnit.AutoSize = true;
            this.LabelUnit.Location = new System.Drawing.Point(334, 405);
            this.LabelUnit.Name = "LabelUnit";
            this.LabelUnit.Size = new System.Drawing.Size(42, 20);
            this.LabelUnit.TabIndex = 6;
            this.LabelUnit.Text = "Unit:";
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            this.Unit.Location = new System.Drawing.Point(402, 402);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(121, 28);
            this.Unit.TabIndex = 7;
            // 
            // ProjectApply
            // 
            this.ProjectApply.FormattingEnabled = true;
            this.ProjectApply.Location = new System.Drawing.Point(98, 405);
            this.ProjectApply.Name = "ProjectApply";
            this.ProjectApply.Size = new System.Drawing.Size(121, 28);
            this.ProjectApply.TabIndex = 8;
            this.ProjectApply.SelectedIndexChanged += new System.EventHandler(this.ProjectApply_SelectedIndexChanged);
            // 
            // ProjectSort
            // 
            this.ProjectSort.FormattingEnabled = true;
            this.ProjectSort.Location = new System.Drawing.Point(402, 35);
            this.ProjectSort.Name = "ProjectSort";
            this.ProjectSort.Size = new System.Drawing.Size(121, 28);
            this.ProjectSort.TabIndex = 9;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(148, 35);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(122, 26);
            this.Price.TabIndex = 10;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(578, 33);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(108, 30);
            this.View.TabIndex = 11;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(578, 450);
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
            this.MaxApplications.Location = new System.Drawing.Point(94, 332);
            this.MaxApplications.Name = "MaxApplications";
            this.MaxApplications.Size = new System.Drawing.Size(19, 20);
            this.MaxApplications.TabIndex = 13;
            this.MaxApplications.Text = "()";
            // 
            // Manage
            // 
            this.Manage.Location = new System.Drawing.Point(367, 450);
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
            this.YourApplications.Location = new System.Drawing.Point(94, 363);
            this.YourApplications.Name = "YourApplications";
            this.YourApplications.Size = new System.Drawing.Size(19, 20);
            this.YourApplications.TabIndex = 15;
            this.YourApplications.Text = "()";
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
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
    }
}