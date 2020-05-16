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
            this.label_Title = new System.Windows.Forms.Label();
            this.listBox_Projects = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmployeeName = new System.Windows.Forms.ComboBox();
            this.labelname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ViewProjs
            // 
            this.button_ViewProjs.Location = new System.Drawing.Point(26, 25);
            this.button_ViewProjs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ViewProjs.Name = "button_ViewProjs";
            this.button_ViewProjs.Size = new System.Drawing.Size(155, 34);
            this.button_ViewProjs.TabIndex = 11;
            this.button_ViewProjs.Text = "View Projects";
            this.button_ViewProjs.UseVisualStyleBackColor = true;
            this.button_ViewProjs.Click += new System.EventHandler(this.button_ViewProjs_Click);
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Location = new System.Drawing.Point(12, 124);
            this.dataGridView_Employees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.RowHeadersWidth = 51;
            this.dataGridView_Employees.RowTemplate.Height = 24;
            this.dataGridView_Employees.Size = new System.Drawing.Size(1153, 578);
            this.dataGridView_Employees.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1194, 687);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Double Click to View Project Details";
            this.label3.Visible = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(579, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(196, 32);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "All Employees";
            // 
            // listBox_Projects
            // 
            this.listBox_Projects.FormattingEnabled = true;
            this.listBox_Projects.ItemHeight = 20;
            this.listBox_Projects.Location = new System.Drawing.Point(1179, 165);
            this.listBox_Projects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Projects.Name = "listBox_Projects";
            this.listBox_Projects.Size = new System.Drawing.Size(214, 504);
            this.listBox_Projects.TabIndex = 7;
            this.listBox_Projects.DoubleClick += new System.EventHandler(this.listBox_Projects_DoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(506, 54);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 33);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add Employee";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(26, 66);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(155, 33);
            this.Info.TabIndex = 14;
            this.Info.Text = "Employee Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(26, 101);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 33);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete Employee";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button_ViewProjs);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Location = new System.Drawing.Point(1179, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmployeeName);
            this.groupBox2.Controls.Add(this.labelname);
            this.groupBox2.Location = new System.Drawing.Point(38, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 84);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // EmployeeName
            // 
            this.EmployeeName.FormattingEnabled = true;
            this.EmployeeName.Location = new System.Drawing.Point(137, 25);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(146, 28);
            this.EmployeeName.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(6, 33);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(125, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Employee Name";
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1444, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.listBox_Projects);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEmployees_FormClosed);
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ViewProjs;
        private System.Windows.Forms.DataGridView dataGridView_Employees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListBox listBox_Projects;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox EmployeeName;
        private System.Windows.Forms.Label labelname;
    }
}