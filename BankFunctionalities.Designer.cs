namespace Housing_Database_Project
{
    partial class BankFunctionalities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankFunctionalities));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Btn_ChangeFees = new System.Windows.Forms.Button();
            this.CompletedTransactions = new System.Windows.Forms.Button();
            this.NewTransaction = new System.Windows.Forms.Button();
            this.TF1 = new System.Windows.Forms.TextBox();
            this.TF2 = new System.Windows.Forms.TextBox();
            this.TF3 = new System.Windows.Forms.TextBox();
            this.TF4 = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Btn_ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(133, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Jew";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(15, 549);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(112, 35);
            this.Btn_LogOut.TabIndex = 12;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Btn_ChangeFees
            // 
            this.Btn_ChangeFees.Location = new System.Drawing.Point(27, 284);
            this.Btn_ChangeFees.Name = "Btn_ChangeFees";
            this.Btn_ChangeFees.Size = new System.Drawing.Size(87, 35);
            this.Btn_ChangeFees.TabIndex = 15;
            this.Btn_ChangeFees.Text = "Change ";
            this.Btn_ChangeFees.UseVisualStyleBackColor = true;
            this.Btn_ChangeFees.Click += new System.EventHandler(this.Btn_ChangeFees_Click);
            // 
            // CompletedTransactions
            // 
            this.CompletedTransactions.Location = new System.Drawing.Point(12, 455);
            this.CompletedTransactions.Name = "CompletedTransactions";
            this.CompletedTransactions.Size = new System.Drawing.Size(238, 35);
            this.CompletedTransactions.TabIndex = 16;
            this.CompletedTransactions.Text = "View Completed Transactions";
            this.CompletedTransactions.UseVisualStyleBackColor = true;
            this.CompletedTransactions.Click += new System.EventHandler(this.CompletedTransactions_Click);
            // 
            // NewTransaction
            // 
            this.NewTransaction.Location = new System.Drawing.Point(12, 414);
            this.NewTransaction.Name = "NewTransaction";
            this.NewTransaction.Size = new System.Drawing.Size(238, 35);
            this.NewTransaction.TabIndex = 17;
            this.NewTransaction.Text = "Create New Transactions";
            this.NewTransaction.UseVisualStyleBackColor = true;
            this.NewTransaction.Click += new System.EventHandler(this.NewTransaction_Click);
            // 
            // TF1
            // 
            this.TF1.BackColor = System.Drawing.Color.Black;
            this.TF1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TF1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TF1.Location = new System.Drawing.Point(27, 259);
            this.TF1.Name = "TF1";
            this.TF1.ReadOnly = true;
            this.TF1.Size = new System.Drawing.Size(136, 19);
            this.TF1.TabIndex = 18;
            this.TF1.Text = "Transaction Fees";
            // 
            // TF2
            // 
            this.TF2.Location = new System.Drawing.Point(169, 256);
            this.TF2.Name = "TF2";
            this.TF2.ReadOnly = true;
            this.TF2.Size = new System.Drawing.Size(136, 26);
            this.TF2.TabIndex = 19;
            // 
            // TF3
            // 
            this.TF3.BackColor = System.Drawing.Color.Black;
            this.TF3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TF3.ForeColor = System.Drawing.Color.White;
            this.TF3.Location = new System.Drawing.Point(27, 341);
            this.TF3.Name = "TF3";
            this.TF3.ReadOnly = true;
            this.TF3.Size = new System.Drawing.Size(136, 19);
            this.TF3.TabIndex = 20;
            this.TF3.Text = "New Fees";
            // 
            // TF4
            // 
            this.TF4.Location = new System.Drawing.Point(169, 341);
            this.TF4.Name = "TF4";
            this.TF4.Size = new System.Drawing.Size(136, 26);
            this.TF4.TabIndex = 21;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(27, 373);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(87, 35);
            this.Confirm.TabIndex = 22;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Btn_ChangePass
            // 
            this.Btn_ChangePass.Location = new System.Drawing.Point(12, 496);
            this.Btn_ChangePass.Name = "Btn_ChangePass";
            this.Btn_ChangePass.Size = new System.Drawing.Size(238, 35);
            this.Btn_ChangePass.TabIndex = 23;
            this.Btn_ChangePass.Text = "Change Password";
            this.Btn_ChangePass.UseVisualStyleBackColor = true;
            this.Btn_ChangePass.Click += new System.EventHandler(this.Btn_ChangePass_Click);
            // 
            // BankFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 600);
            this.Controls.Add(this.Btn_ChangePass);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TF4);
            this.Controls.Add(this.TF3);
            this.Controls.Add(this.TF2);
            this.Controls.Add(this.TF1);
            this.Controls.Add(this.NewTransaction);
            this.Controls.Add(this.CompletedTransactions);
            this.Controls.Add(this.Btn_ChangeFees);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BankFunctionalities";
            this.Text = "BankFunctionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankFunctionalities_FormClosed);
            this.Load += new System.EventHandler(this.BankFunctionalities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button Btn_ChangeFees;
        private System.Windows.Forms.Button CompletedTransactions;
        private System.Windows.Forms.Button NewTransaction;
        private System.Windows.Forms.TextBox TF1;
        private System.Windows.Forms.TextBox TF2;
        private System.Windows.Forms.TextBox TF3;
        private System.Windows.Forms.TextBox TF4;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Btn_ChangePass;
    }
}