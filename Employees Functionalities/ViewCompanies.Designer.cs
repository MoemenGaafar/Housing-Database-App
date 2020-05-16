namespace Housing_Database_Project.Employees_Functionalities
{
    partial class ViewCompanies
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
            this.listBox_Projects = new System.Windows.Forms.ListBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Companies = new System.Windows.Forms.DataGridView();
            this.button_ViewProjs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CompanyName = new System.Windows.Forms.ComboBox();
            this.labelname = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Rate = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Projects
            // 
            this.listBox_Projects.FormattingEnabled = true;
            this.listBox_Projects.ItemHeight = 20;
            this.listBox_Projects.Location = new System.Drawing.Point(963, 212);
            this.listBox_Projects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Projects.Name = "listBox_Projects";
            this.listBox_Projects.Size = new System.Drawing.Size(214, 344);
            this.listBox_Projects.TabIndex = 1;
            this.listBox_Projects.DoubleClick += new System.EventHandler(this.listBox_Projects_DoubleClick);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(500, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(199, 32);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "All Companies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(959, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double Click to View Project Details";
            this.label3.Visible = false;
            // 
            // dataGridView_Companies
            // 
            this.dataGridView_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Companies.Location = new System.Drawing.Point(25, 205);
            this.dataGridView_Companies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Companies.Name = "dataGridView_Companies";
            this.dataGridView_Companies.RowHeadersWidth = 51;
            this.dataGridView_Companies.RowTemplate.Height = 24;
            this.dataGridView_Companies.Size = new System.Drawing.Size(900, 375);
            this.dataGridView_Companies.TabIndex = 5;
            // 
            // button_ViewProjs
            // 
            this.button_ViewProjs.Location = new System.Drawing.Point(17, 21);
            this.button_ViewProjs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ViewProjs.Name = "button_ViewProjs";
            this.button_ViewProjs.Size = new System.Drawing.Size(155, 34);
            this.button_ViewProjs.TabIndex = 6;
            this.button_ViewProjs.Text = "View Projects";
            this.button_ViewProjs.UseVisualStyleBackColor = true;
            this.button_ViewProjs.Click += new System.EventHandler(this.button_ViewProjs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.Rating);
            this.groupBox1.Controls.Add(this.Rate);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.button_ViewProjs);
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 71);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Company";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(637, 22);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 33);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete Company";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(476, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(155, 33);
            this.Info.TabIndex = 14;
            this.Info.Text = "Company Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Visible = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CompanyName);
            this.groupBox2.Controls.Add(this.labelname);
            this.groupBox2.Location = new System.Drawing.Point(25, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 84);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // CompanyName
            // 
            this.CompanyName.FormattingEnabled = true;
            this.CompanyName.Location = new System.Drawing.Point(137, 25);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(146, 28);
            this.CompanyName.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(6, 33);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(122, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Company Name";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(384, 77);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 33);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add Company";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(315, 21);
            this.Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(155, 34);
            this.Rate.TabIndex = 16;
            this.Rate.Text = "Update Rating";
            this.Rate.UseVisualStyleBackColor = true;
            this.Rate.Click += new System.EventHandler(this.Rate_Click);
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(189, 25);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(120, 26);
            this.Rating.TabIndex = 21;
            // 
            // ViewCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Companies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.listBox_Projects);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewCompanies";
            this.Text = "ViewCompanies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCompanies_FormClosed);
            this.Load += new System.EventHandler(this.ViewCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Projects;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Companies;
        private System.Windows.Forms.Button button_ViewProjs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CompanyName;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown Rating;
        private System.Windows.Forms.Button Rate;
    }
}