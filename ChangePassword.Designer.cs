namespace Housing_Database_Project
{
    partial class ChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Password ";
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(153, 54);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(170, 22);
            this.TxtBx_username.TabIndex = 2;
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(153, 80);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(170, 22);
            this.TxtBx_pass.TabIndex = 3;
            this.TxtBx_pass.UseSystemPasswordChar = true;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(153, 183);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(170, 22);
            this.NewPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(69, 126);
            this.Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(88, 26);
            this.Check.TabIndex = 8;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(69, 222);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(88, 26);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "Confim";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 294);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassword_FormClosed);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Confirm;
    }
}