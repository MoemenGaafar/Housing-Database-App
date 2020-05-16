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
            this.button_AddUnits = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Citizen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Units)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Units
            // 
            this.dataGridView_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Units.Location = new System.Drawing.Point(14, 220);
            this.dataGridView_Units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Units.Name = "dataGridView_Units";
            this.dataGridView_Units.RowHeadersWidth = 51;
            this.dataGridView_Units.RowTemplate.Height = 24;
            this.dataGridView_Units.Size = new System.Drawing.Size(1110, 402);
            this.dataGridView_Units.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Project);
            this.groupBox1.Controls.Add(this.comboBox_Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(306, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(538, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBox_Project
            // 
            this.comboBox_Project.FormattingEnabled = true;
            this.comboBox_Project.Location = new System.Drawing.Point(331, 44);
            this.comboBox_Project.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Project.Name = "comboBox_Project";
            this.comboBox_Project.Size = new System.Drawing.Size(152, 28);
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
            this.label4.Location = new System.Drawing.Point(266, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Units";
            // 
            // button_AddUnits
            // 
            this.button_AddUnits.Location = new System.Drawing.Point(892, 8);
            this.button_AddUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddUnits.Name = "button_AddUnits";
            this.button_AddUnits.Size = new System.Drawing.Size(144, 36);
            this.button_AddUnits.TabIndex = 101;
            this.button_AddUnits.Text = "Add Units";
            this.button_AddUnits.UseVisualStyleBackColor = true;
            this.button_AddUnits.Visible = false;
            this.button_AddUnits.Click += new System.EventHandler(this.button_AddUnits_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(892, 96);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(144, 36);
            this.Status.TabIndex = 102;
            this.Status.Text = "Change Status";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.Visible = false;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(892, 52);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(144, 36);
            this.Delete.TabIndex = 103;
            this.Delete.Text = "Delete Selected";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Citizen
            // 
            this.Citizen.FormattingEnabled = true;
            this.Citizen.Items.AddRange(new object[] {
            "All",
            "Sold",
            "Not Sold"});
            this.Citizen.Location = new System.Drawing.Point(971, 141);
            this.Citizen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Citizen.Name = "Citizen";
            this.Citizen.Size = new System.Drawing.Size(152, 28);
            this.Citizen.TabIndex = 9;
            this.Citizen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buying Citizen";
            this.label2.Visible = false;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(892, 176);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(144, 36);
            this.Confirm.TabIndex = 104;
            this.Confirm.Text = "Confirm ";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Visible = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // EMP_ViewUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 636);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Citizen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button_AddUnits);
            this.Controls.Add(this.dataGridView_Units);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button_AddUnits;
        private System.Windows.Forms.Button Status;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox Citizen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm;
    }
}