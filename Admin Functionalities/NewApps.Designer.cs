namespace Housing_Database_Project
{
    partial class NewApps
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CitProject = new System.Windows.Forms.ComboBox();
            this.CitAdd = new System.Windows.Forms.Button();
            this.CitUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CitCitizen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComProject = new System.Windows.Forms.ComboBox();
            this.ComAdd = new System.Windows.Forms.Button();
            this.ComCompany = new System.Windows.Forms.ComboBox();
            this.ComPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CitProject);
            this.groupBox2.Controls.Add(this.CitAdd);
            this.groupBox2.Controls.Add(this.CitUnit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CitCitizen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(360, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 189);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Citizen Application";
            // 
            // CitProject
            // 
            this.CitProject.FormattingEnabled = true;
            this.CitProject.Location = new System.Drawing.Point(120, 66);
            this.CitProject.Name = "CitProject";
            this.CitProject.Size = new System.Drawing.Size(121, 28);
            this.CitProject.TabIndex = 10;
            this.CitProject.SelectionChangeCommitted += new System.EventHandler(this.CitProject_SelectionChangeCommitted_1);
            // 
            // CitAdd
            // 
            this.CitAdd.Location = new System.Drawing.Point(120, 138);
            this.CitAdd.Name = "CitAdd";
            this.CitAdd.Size = new System.Drawing.Size(98, 32);
            this.CitAdd.TabIndex = 10;
            this.CitAdd.Text = "Add";
            this.CitAdd.UseVisualStyleBackColor = true;
            this.CitAdd.Click += new System.EventHandler(this.CitAdd_Click);
            // 
            // CitUnit
            // 
            this.CitUnit.FormattingEnabled = true;
            this.CitUnit.Location = new System.Drawing.Point(120, 100);
            this.CitUnit.Name = "CitUnit";
            this.CitUnit.Size = new System.Drawing.Size(121, 28);
            this.CitUnit.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unit Number:";
            // 
            // CitCitizen
            // 
            this.CitCitizen.FormattingEnabled = true;
            this.CitCitizen.Location = new System.Drawing.Point(120, 32);
            this.CitCitizen.Name = "CitCitizen";
            this.CitCitizen.Size = new System.Drawing.Size(121, 28);
            this.CitCitizen.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Citizen ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Project ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComProject);
            this.groupBox1.Controls.Add(this.ComAdd);
            this.groupBox1.Controls.Add(this.ComCompany);
            this.groupBox1.Controls.Add(this.ComPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Application";
            // 
            // ComProject
            // 
            this.ComProject.FormattingEnabled = true;
            this.ComProject.Location = new System.Drawing.Point(137, 32);
            this.ComProject.Name = "ComProject";
            this.ComProject.Size = new System.Drawing.Size(121, 28);
            this.ComProject.TabIndex = 9;
            // 
            // ComAdd
            // 
            this.ComAdd.Location = new System.Drawing.Point(137, 138);
            this.ComAdd.Name = "ComAdd";
            this.ComAdd.Size = new System.Drawing.Size(98, 32);
            this.ComAdd.TabIndex = 8;
            this.ComAdd.Text = "Add";
            this.ComAdd.UseVisualStyleBackColor = true;
            this.ComAdd.Click += new System.EventHandler(this.ComAdd_Click);
            // 
            // ComCompany
            // 
            this.ComCompany.FormattingEnabled = true;
            this.ComCompany.Location = new System.Drawing.Point(138, 66);
            this.ComCompany.Name = "ComCompany";
            this.ComCompany.Size = new System.Drawing.Size(121, 28);
            this.ComCompany.TabIndex = 6;
            // 
            // ComPrice
            // 
            this.ComPrice.Location = new System.Drawing.Point(138, 106);
            this.ComPrice.Name = "ComPrice";
            this.ComPrice.Size = new System.Drawing.Size(120, 26);
            this.ComPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bidding Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID:";
            // 
            // NewApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 218);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewApps";
            this.Text = "NewApps";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewApps_FormClosed);
            this.Load += new System.EventHandler(this.NewApps_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CitProject;
        private System.Windows.Forms.Button CitAdd;
        private System.Windows.Forms.ComboBox CitUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CitCitizen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComProject;
        private System.Windows.Forms.Button ComAdd;
        private System.Windows.Forms.ComboBox ComCompany;
        private System.Windows.Forms.NumericUpDown ComPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}