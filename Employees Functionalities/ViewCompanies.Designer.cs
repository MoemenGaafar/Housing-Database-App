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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Projects
            // 
            this.listBox_Projects.FormattingEnabled = true;
            this.listBox_Projects.ItemHeight = 16;
            this.listBox_Projects.Location = new System.Drawing.Point(866, 108);
            this.listBox_Projects.Name = "listBox_Projects";
            this.listBox_Projects.Size = new System.Drawing.Size(191, 260);
            this.listBox_Projects.TabIndex = 1;
            this.listBox_Projects.DoubleClick += new System.EventHandler(this.listBox_Projects_DoubleClick);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(444, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(169, 29);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "All Companies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double Click to View Project Details";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView_Companies
            // 
            this.dataGridView_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Companies.Location = new System.Drawing.Point(26, 71);
            this.dataGridView_Companies.Name = "dataGridView_Companies";
            this.dataGridView_Companies.RowHeadersWidth = 51;
            this.dataGridView_Companies.RowTemplate.Height = 24;
            this.dataGridView_Companies.Size = new System.Drawing.Size(800, 330);
            this.dataGridView_Companies.TabIndex = 5;
            // 
            // button_ViewProjs
            // 
            this.button_ViewProjs.Location = new System.Drawing.Point(908, 71);
            this.button_ViewProjs.Name = "button_ViewProjs";
            this.button_ViewProjs.Size = new System.Drawing.Size(115, 27);
            this.button_ViewProjs.TabIndex = 6;
            this.button_ViewProjs.Text = "View Projects";
            this.button_ViewProjs.UseVisualStyleBackColor = true;
            this.button_ViewProjs.Click += new System.EventHandler(this.button_ViewProjs_Click);
            // 
            // ViewCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 417);
            this.Controls.Add(this.button_ViewProjs);
            this.Controls.Add(this.dataGridView_Companies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.listBox_Projects);
            this.Name = "ViewCompanies";
            this.Text = "ViewCompanies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCompanies_FormClosed);
            this.Load += new System.EventHandler(this.ViewCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Projects;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Companies;
        private System.Windows.Forms.Button button_ViewProjs;
    }
}