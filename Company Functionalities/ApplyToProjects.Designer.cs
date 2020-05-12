namespace Housing_Database_Project.Company_Functionalities
{
    partial class ApplyToProjects
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
            this.button_ViewProj = new System.Windows.Forms.Button();
            this.dataGridView_Projects = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_RoomPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Retrieve = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_NumApps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ViewProj
            // 
            this.button_ViewProj.Location = new System.Drawing.Point(813, 71);
            this.button_ViewProj.Name = "button_ViewProj";
            this.button_ViewProj.Size = new System.Drawing.Size(128, 28);
            this.button_ViewProj.TabIndex = 9;
            this.button_ViewProj.Text = "Project Details";
            this.button_ViewProj.UseVisualStyleBackColor = true;
            this.button_ViewProj.Click += new System.EventHandler(this.button_ViewProj_Click);
            // 
            // dataGridView_Projects
            // 
            this.dataGridView_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Projects.Location = new System.Drawing.Point(12, 176);
            this.dataGridView_Projects.Name = "dataGridView_Projects";
            this.dataGridView_Projects.RowHeadersWidth = 51;
            this.dataGridView_Projects.RowTemplate.Height = 24;
            this.dataGridView_Projects.Size = new System.Drawing.Size(987, 322);
            this.dataGridView_Projects.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_RoomPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_City);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(240, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // textBox_RoomPrice
            // 
            this.textBox_RoomPrice.Location = new System.Drawing.Point(164, 33);
            this.textBox_RoomPrice.Name = "textBox_RoomPrice";
            this.textBox_RoomPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox_RoomPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minimum Room Price";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(350, 31);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(136, 24);
            this.comboBox_City.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Projects";
            // 
            // button_Retrieve
            // 
            this.button_Retrieve.Location = new System.Drawing.Point(73, 88);
            this.button_Retrieve.Name = "button_Retrieve";
            this.button_Retrieve.Size = new System.Drawing.Size(128, 28);
            this.button_Retrieve.TabIndex = 10;
            this.button_Retrieve.Text = "Retrieve";
            this.button_Retrieve.UseVisualStyleBackColor = true;
            this.button_Retrieve.Click += new System.EventHandler(this.button_Retrieve_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(813, 105);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(128, 28);
            this.button_Apply.TabIndex = 11;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Pending Applications:";
            // 
            // label_NumApps
            // 
            this.label_NumApps.AutoSize = true;
            this.label_NumApps.ForeColor = System.Drawing.Color.Red;
            this.label_NumApps.Location = new System.Drawing.Point(538, 146);
            this.label_NumApps.Name = "label_NumApps";
            this.label_NumApps.Size = new System.Drawing.Size(37, 17);
            this.label_NumApps.TabIndex = 12;
            this.label_NumApps.Text = "Num";
            // 
            // ApplyToProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.label_NumApps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Retrieve);
            this.Controls.Add(this.button_ViewProj);
            this.Controls.Add(this.dataGridView_Projects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ApplyToProjects";
            this.Text = "ApplyToProjects";
            this.Activated += new System.EventHandler(this.ApplyToProjects_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplyToProjects_FormClosed);
            this.Load += new System.EventHandler(this.ApplyToProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ViewProj;
        private System.Windows.Forms.DataGridView dataGridView_Projects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RoomPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Retrieve;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_NumApps;
    }
}