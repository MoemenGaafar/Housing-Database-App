namespace Housing_Database_Project
{
    partial class ViewApplications
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
            this.button_ViewCit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Apps = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_ProjectID = new System.Windows.Forms.ComboBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.comboBox_From = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Apps)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ViewCit
            // 
            this.button_ViewCit.Enabled = false;
            this.button_ViewCit.Location = new System.Drawing.Point(816, 93);
            this.button_ViewCit.Name = "button_ViewCit";
            this.button_ViewCit.Size = new System.Drawing.Size(117, 28);
            this.button_ViewCit.TabIndex = 18;
            this.button_ViewCit.Text = "Citizen Details";
            this.button_ViewCit.UseVisualStyleBackColor = true;
            this.button_ViewCit.Click += new System.EventHandler(this.button_ViewCit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "W: Waiting - A: Accepted - R: Rejected - D: Done";
            // 
            // dataGridView_Apps
            // 
            this.dataGridView_Apps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Apps.Location = new System.Drawing.Point(12, 177);
            this.dataGridView_Apps.Name = "dataGridView_Apps";
            this.dataGridView_Apps.RowHeadersWidth = 51;
            this.dataGridView_Apps.RowTemplate.Height = 24;
            this.dataGridView_Apps.Size = new System.Drawing.Size(987, 322);
            this.dataGridView_Apps.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_From);
            this.groupBox1.Controls.Add(this.comboBox_ProjectID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(82, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 83);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_ProjectID
            // 
            this.comboBox_ProjectID.FormattingEnabled = true;
            this.comboBox_ProjectID.Location = new System.Drawing.Point(307, 35);
            this.comboBox_ProjectID.Name = "comboBox_ProjectID";
            this.comboBox_ProjectID.Size = new System.Drawing.Size(136, 24);
            this.comboBox_ProjectID.TabIndex = 7;
            this.comboBox_ProjectID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProjectID_SelectedIndexChanged);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "All",
            "Waiting",
            "Accepted",
            "Rejected",
            "Done"});
            this.comboBox_Status.Location = new System.Drawing.Point(67, 35);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Status.TabIndex = 6;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project ID";
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
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(458, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(177, 29);
            this.label_Title.TabIndex = 12;
            this.label_Title.Text = "All Applications";
            // 
            // comboBox_From
            // 
            this.comboBox_From.FormattingEnabled = true;
            this.comboBox_From.Items.AddRange(new object[] {
            "Company",
            "Citizen"});
            this.comboBox_From.Location = new System.Drawing.Point(541, 34);
            this.comboBox_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_From.Name = "comboBox_From";
            this.comboBox_From.Size = new System.Drawing.Size(108, 24);
            this.comboBox_From.TabIndex = 20;
            this.comboBox_From.SelectedIndexChanged += new System.EventHandler(this.comboBox_From_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "From";
            // 
            // ViewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.button_ViewCit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Apps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Title);
            this.Name = "ViewApplications";
            this.Text = "ViewApplications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewApplications_FormClosed);
            this.Load += new System.EventHandler(this.ViewApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Apps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ViewCit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Apps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_ProjectID;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ComboBox comboBox_From;
        private System.Windows.Forms.Label label1;
    }
}