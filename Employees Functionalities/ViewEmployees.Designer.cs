namespace Housing_Database_Project.Employees_Functionalities
{
    partial class ViewEmployees
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
            this.button_ViewProjs = new System.Windows.Forms.Button();
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Projects = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ViewProjs
            // 
            this.button_ViewProjs.Location = new System.Drawing.Point(1182, 74);
            this.button_ViewProjs.Name = "button_ViewProjs";
            this.button_ViewProjs.Size = new System.Drawing.Size(115, 27);
            this.button_ViewProjs.TabIndex = 11;
            this.button_ViewProjs.Text = "View Projects";
            this.button_ViewProjs.UseVisualStyleBackColor = true;
            this.button_ViewProjs.Click += new System.EventHandler(this.button_ViewProjs_Click);
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Location = new System.Drawing.Point(19, 74);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.RowHeadersWidth = 51;
            this.dataGridView_Employees.RowTemplate.Height = 24;
            this.dataGridView_Employees.Size = new System.Drawing.Size(1090, 501);
            this.dataGridView_Employees.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1122, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Double Click to View Project Details";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Employees";
            // 
            // listBox_Projects
            // 
            this.listBox_Projects.FormattingEnabled = true;
            this.listBox_Projects.ItemHeight = 16;
            this.listBox_Projects.Location = new System.Drawing.Point(1146, 107);
            this.listBox_Projects.Name = "listBox_Projects";
            this.listBox_Projects.Size = new System.Drawing.Size(191, 436);
            this.listBox_Projects.TabIndex = 7;
            this.listBox_Projects.DoubleClick += new System.EventHandler(this.listBox_Projects_DoubleClick);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 587);
            this.Controls.Add(this.button_ViewProjs);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Projects);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEmployees_FormClosed);
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ViewProjs;
        private System.Windows.Forms.DataGridView dataGridView_Employees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Projects;
    }
}