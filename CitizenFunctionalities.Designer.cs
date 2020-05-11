namespace Housing_Database_Project
{
    partial class CitizenFunctionalities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitizenFunctionalities));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.Applications = new System.Windows.Forms.Button();
            this.Units = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(130, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Peasant";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(15, 549);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(112, 35);
            this.Btn_LogOut.TabIndex = 13;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(15, 491);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(183, 34);
            this.Password.TabIndex = 14;
            this.Password.Text = "Change Password";
            this.Password.UseVisualStyleBackColor = true;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Transactions
            // 
            this.Transactions.Location = new System.Drawing.Point(15, 431);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(231, 34);
            this.Transactions.TabIndex = 15;
            this.Transactions.Text = "Manage Payments";
            this.Transactions.UseVisualStyleBackColor = true;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // Applications
            // 
            this.Applications.Location = new System.Drawing.Point(15, 372);
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(231, 34);
            this.Applications.TabIndex = 16;
            this.Applications.Text = "Manage Applications";
            this.Applications.UseVisualStyleBackColor = true;
            this.Applications.Click += new System.EventHandler(this.Applications_Click);
            // 
            // Units
            // 
            this.Units.Location = new System.Drawing.Point(15, 310);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(253, 34);
            this.Units.TabIndex = 17;
            this.Units.Text = "View / Apply to Availabe Units";
            this.Units.UseVisualStyleBackColor = true;
            this.Units.Click += new System.EventHandler(this.Units_Click);
            // 
            // CitizenFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 600);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Applications);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CitizenFunctionalities";
            this.Text = "CitizenFunctionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CitizenFunctionalities_FormClosed);
            this.Load += new System.EventHandler(this.CitizenFunctionalities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button Password;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button Applications;
        private System.Windows.Forms.Button Units;
    }
}