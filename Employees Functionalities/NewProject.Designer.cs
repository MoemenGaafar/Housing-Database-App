namespace Housing_Database_Project.Employees_Functionalities
{
    partial class NewProject
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label_Nationalid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ProjEmps = new System.Windows.Forms.ComboBox();
            this.textBox_RoomPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "New Project Form";
            // 
            // textBox_City
            // 
            this.textBox_City.BackColor = System.Drawing.Color.White;
            this.textBox_City.Location = new System.Drawing.Point(70, 77);
            this.textBox_City.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(132, 22);
            this.textBox_City.TabIndex = 39;
            // 
            // label_Nationalid
            // 
            this.label_Nationalid.AutoSize = true;
            this.label_Nationalid.BackColor = System.Drawing.Color.Transparent;
            this.label_Nationalid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Nationalid.Location = new System.Drawing.Point(31, 80);
            this.label_Nationalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nationalid.Name = "label_Nationalid";
            this.label_Nationalid.Size = new System.Drawing.Size(31, 17);
            this.label_Nationalid.TabIndex = 40;
            this.label_Nationalid.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Assign Projects Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_ProjEmps
            // 
            this.comboBox_ProjEmps.FormattingEnabled = true;
            this.comboBox_ProjEmps.Location = new System.Drawing.Point(210, 141);
            this.comboBox_ProjEmps.Name = "comboBox_ProjEmps";
            this.comboBox_ProjEmps.Size = new System.Drawing.Size(297, 24);
            this.comboBox_ProjEmps.TabIndex = 42;
            // 
            // textBox_RoomPrice
            // 
            this.textBox_RoomPrice.BackColor = System.Drawing.Color.White;
            this.textBox_RoomPrice.Location = new System.Drawing.Point(375, 77);
            this.textBox_RoomPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RoomPrice.Name = "textBox_RoomPrice";
            this.textBox_RoomPrice.Size = new System.Drawing.Size(132, 22);
            this.textBox_RoomPrice.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(286, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Room Price";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(221, 196);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(84, 28);
            this.button_Add.TabIndex = 45;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 236);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_RoomPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ProjEmps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label_Nationalid);
            this.Controls.Add(this.label4);
            this.Name = "NewProject";
            this.Text = "NewProject";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label label_Nationalid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ProjEmps;
        private System.Windows.Forms.TextBox textBox_RoomPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
    }
}