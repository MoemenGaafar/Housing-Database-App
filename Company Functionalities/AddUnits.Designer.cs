namespace Housing_Database_Project.Company_Functionalities
{
    partial class AddUnits
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
            this.label_ProjID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NumUnits = new System.Windows.Forms.TextBox();
            this.textBox_NumRooms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Units to Project: ";
            // 
            // label_ProjID
            // 
            this.label_ProjID.AutoSize = true;
            this.label_ProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProjID.ForeColor = System.Drawing.Color.Red;
            this.label_ProjID.Location = new System.Drawing.Point(249, 9);
            this.label_ProjID.Name = "label_ProjID";
            this.label_ProjID.Size = new System.Drawing.Size(53, 20);
            this.label_ProjID.TabIndex = 1;
            this.label_ProjID.Text = "label2";
            this.label_ProjID.Click += new System.EventHandler(this.label_ProjID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Units to Add";
            // 
            // textBox_NumUnits
            // 
            this.textBox_NumUnits.Location = new System.Drawing.Point(202, 66);
            this.textBox_NumUnits.Name = "textBox_NumUnits";
            this.textBox_NumUnits.Size = new System.Drawing.Size(100, 22);
            this.textBox_NumUnits.TabIndex = 3;
            // 
            // textBox_NumRooms
            // 
            this.textBox_NumRooms.Location = new System.Drawing.Point(202, 116);
            this.textBox_NumRooms.Name = "textBox_NumRooms";
            this.textBox_NumRooms.Size = new System.Drawing.Size(100, 22);
            this.textBox_NumRooms.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of  Rooms in Each";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(114, 160);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(94, 27);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 199);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_NumRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NumUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ProjID);
            this.Controls.Add(this.label1);
            this.Name = "AddUnits";
            this.Text = "AddUnits";
            this.Load += new System.EventHandler(this.AddUnits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ProjID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NumUnits;
        private System.Windows.Forms.TextBox textBox_NumRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Add;
    }
}