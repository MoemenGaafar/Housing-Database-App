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
            this.comboBox_From = new System.Windows.Forms.ComboBox();
            this.comboBox_ProjectID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ConfirmStatus = new System.Windows.Forms.Button();
            this.ChangeStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangePrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Apps)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ViewCit
            // 
            this.button_ViewCit.Enabled = false;
            this.button_ViewCit.Location = new System.Drawing.Point(850, 140);
            this.button_ViewCit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ViewCit.Name = "button_ViewCit";
            this.button_ViewCit.Size = new System.Drawing.Size(132, 35);
            this.button_ViewCit.TabIndex = 18;
            this.button_ViewCit.Text = "Citizen Details";
            this.button_ViewCit.UseVisualStyleBackColor = true;
            this.button_ViewCit.Click += new System.EventHandler(this.button_ViewCit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "W: Waiting - A: Accepted - R: Rejected - D: Done";
            // 
            // dataGridView_Apps
            // 
            this.dataGridView_Apps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Apps.Location = new System.Drawing.Point(14, 221);
            this.dataGridView_Apps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Apps.Name = "dataGridView_Apps";
            this.dataGridView_Apps.RowHeadersWidth = 51;
            this.dataGridView_Apps.RowTemplate.Height = 24;
            this.dataGridView_Apps.Size = new System.Drawing.Size(1110, 402);
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
            this.groupBox1.Location = new System.Drawing.Point(92, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(752, 104);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_From
            // 
            this.comboBox_From.FormattingEnabled = true;
            this.comboBox_From.Items.AddRange(new object[] {
            "Company",
            "Citizen"});
            this.comboBox_From.Location = new System.Drawing.Point(609, 42);
            this.comboBox_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_From.Name = "comboBox_From";
            this.comboBox_From.Size = new System.Drawing.Size(121, 28);
            this.comboBox_From.TabIndex = 20;
            this.comboBox_From.SelectedIndexChanged += new System.EventHandler(this.comboBox_From_SelectedIndexChanged);
            // 
            // comboBox_ProjectID
            // 
            this.comboBox_ProjectID.FormattingEnabled = true;
            this.comboBox_ProjectID.Location = new System.Drawing.Point(345, 44);
            this.comboBox_ProjectID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_ProjectID.Name = "comboBox_ProjectID";
            this.comboBox_ProjectID.Size = new System.Drawing.Size(152, 28);
            this.comboBox_ProjectID.TabIndex = 7;
            this.comboBox_ProjectID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProjectID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "From";
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
            this.label4.Location = new System.Drawing.Point(261, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project ID";
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
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(515, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(211, 32);
            this.label_Title.TabIndex = 12;
            this.label_Title.Text = "All Applications";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(838, 14);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(132, 35);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(976, 13);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 39);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete Selected";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ConfirmStatus
            // 
            this.ConfirmStatus.Location = new System.Drawing.Point(904, 96);
            this.ConfirmStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmStatus.Name = "ConfirmStatus";
            this.ConfirmStatus.Size = new System.Drawing.Size(132, 35);
            this.ConfirmStatus.TabIndex = 21;
            this.ConfirmStatus.Text = "Confirm";
            this.ConfirmStatus.UseVisualStyleBackColor = true;
            this.ConfirmStatus.Click += new System.EventHandler(this.ConfirmStatus_Click);
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.FormattingEnabled = true;
            this.ChangeStatus.Items.AddRange(new object[] {
            "Waiting",
            "Accepted",
            "Rejected",
            "Done"});
            this.ChangeStatus.Location = new System.Drawing.Point(967, 60);
            this.ChangeStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(152, 28);
            this.ChangeStatus.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "New Status:";
            // 
            // ChangePrice
            // 
            this.ChangePrice.Location = new System.Drawing.Point(996, 138);
            this.ChangePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ChangePrice.Name = "ChangePrice";
            this.ChangePrice.Size = new System.Drawing.Size(120, 26);
            this.ChangePrice.TabIndex = 22;
            this.ChangePrice.Visible = false;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "New Bidding Price:";
            this.label6.Visible = false;
            // 
            // ConfirmPrice
            // 
            this.ConfirmPrice.Location = new System.Drawing.Point(904, 181);
            this.ConfirmPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPrice.Name = "ConfirmPrice";
            this.ConfirmPrice.Size = new System.Drawing.Size(132, 35);
            this.ConfirmPrice.TabIndex = 24;
            this.ConfirmPrice.Text = "Confirm";
            this.ConfirmPrice.UseVisualStyleBackColor = true;
            this.ConfirmPrice.Visible = false;
            this.ConfirmPrice.Click += new System.EventHandler(this.ConfirmPrice_Click);
            // 
            // ViewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 636);
            this.Controls.Add(this.ConfirmPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChangePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangeStatus);
            this.Controls.Add(this.ConfirmStatus);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button_ViewCit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Apps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewApplications";
            this.Text = "ViewApplications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewApplications_FormClosed);
            this.Load += new System.EventHandler(this.ViewApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Apps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePrice)).EndInit();
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ConfirmStatus;
        private System.Windows.Forms.ComboBox ChangeStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ChangePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConfirmPrice;
    }
}