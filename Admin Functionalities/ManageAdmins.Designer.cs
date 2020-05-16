namespace Housing_Database_Project
{
    partial class ManageAdmins
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.MakeHigh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.sth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.sth2 = new System.Windows.Forms.Label();
            this.addPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(353, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(155, 311);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(127, 26);
            this.newPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrators:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password:";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(301, 311);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(101, 33);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(27, 424);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(101, 33);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // MakeHigh
            // 
            this.MakeHigh.Location = new System.Drawing.Point(27, 352);
            this.MakeHigh.Name = "MakeHigh";
            this.MakeHigh.Size = new System.Drawing.Size(192, 31);
            this.MakeHigh.TabIndex = 8;
            this.MakeHigh.Text = "Make High Admin";
            this.MakeHigh.UseVisualStyleBackColor = true;
            this.MakeHigh.Click += new System.EventHandler(this.MakeHigh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Note that by this action, you will not be high admin any longer.)";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(380, 160);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 33);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // sth
            // 
            this.sth.AutoSize = true;
            this.sth.Location = new System.Drawing.Point(376, 86);
            this.sth.Name = "sth";
            this.sth.Size = new System.Drawing.Size(87, 20);
            this.sth.TabIndex = 12;
            this.sth.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Administrator";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(508, 83);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(127, 26);
            this.addName.TabIndex = 10;
            // 
            // sth2
            // 
            this.sth2.AutoSize = true;
            this.sth2.Location = new System.Drawing.Point(376, 128);
            this.sth2.Name = "sth2";
            this.sth2.Size = new System.Drawing.Size(78, 20);
            this.sth2.TabIndex = 16;
            this.sth2.Text = "Password";
            // 
            // addPass
            // 
            this.addPass.Location = new System.Drawing.Point(508, 125);
            this.addPass.Name = "addPass";
            this.addPass.Size = new System.Drawing.Size(127, 26);
            this.addPass.TabIndex = 14;
            // 
            // ManageAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(648, 469);
            this.Controls.Add(this.sth2);
            this.Controls.Add(this.addPass);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.sth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MakeHigh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageAdmins";
            this.Text = "ManageAdmins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageAdmins_FormClosed);
            this.Load += new System.EventHandler(this.ManageAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button MakeHigh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label sth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label sth2;
        private System.Windows.Forms.TextBox addPass;
    }
}