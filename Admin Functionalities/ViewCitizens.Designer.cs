namespace Housing_Database_Project
{
    partial class ViewCitizens
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
            this.Applications = new System.Windows.Forms.Button();
            this.Payments = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Dependents = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CitizenID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Citizen Users";
            // 
            // Applications
            // 
            this.Applications.Location = new System.Drawing.Point(339, 37);
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(151, 33);
            this.Applications.TabIndex = 1;
            this.Applications.Text = "Applications";
            this.Applications.UseVisualStyleBackColor = true;
            this.Applications.Click += new System.EventHandler(this.Applications_Click);
            // 
            // Payments
            // 
            this.Payments.Location = new System.Drawing.Point(496, 37);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(194, 33);
            this.Payments.TabIndex = 2;
            this.Payments.Text = "Units and Payments";
            this.Payments.UseVisualStyleBackColor = true;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(31, 37);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(148, 33);
            this.Info.TabIndex = 3;
            this.Info.Text = "Information";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Dependents
            // 
            this.Dependents.Location = new System.Drawing.Point(185, 37);
            this.Dependents.Name = "Dependents";
            this.Dependents.Size = new System.Drawing.Size(148, 33);
            this.Dependents.TabIndex = 4;
            this.Dependents.Text = "Dependents";
            this.Dependents.UseVisualStyleBackColor = true;
            this.Dependents.Click += new System.EventHandler(this.Dependents_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.Payments);
            this.groupBox1.Controls.Add(this.Dependents);
            this.groupBox1.Controls.Add(this.Applications);
            this.groupBox1.Location = new System.Drawing.Point(40, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Citizen ";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(345, 59);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(148, 33);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add Citizen";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(345, 98);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(148, 33);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete Citizen";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(870, 330);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CitizenID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(40, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 81);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // CitizenID
            // 
            this.CitizenID.FormattingEnabled = true;
            this.CitizenID.Location = new System.Drawing.Point(100, 33);
            this.CitizenID.Name = "CitizenID";
            this.CitizenID.Size = new System.Drawing.Size(146, 28);
            this.CitizenID.TabIndex = 1;
            this.CitizenID.SelectedIndexChanged += new System.EventHandler(this.CitizenID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "National ID";
            // 
            // ViewCitizens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ViewCitizens";
            this.Text = "ViewCitizens";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCitizens_FormClosed);
            this.Load += new System.EventHandler(this.ViewCitizens_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Applications;
        private System.Windows.Forms.Button Payments;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Dependents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CitizenID;
        private System.Windows.Forms.Label label2;
    }
}