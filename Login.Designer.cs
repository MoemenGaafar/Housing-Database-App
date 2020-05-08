namespace Housing_Database_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.radioButton_Employee = new System.Windows.Forms.RadioButton();
            this.radioButton_Company = new System.Windows.Forms.RadioButton();
            this.radioButton_Citizen = new System.Windows.Forms.RadioButton();
            this.radioButton_Bank = new System.Windows.Forms.RadioButton();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.BackColor = System.Drawing.Color.White;
            this.TxtBx_username.Location = new System.Drawing.Point(139, 268);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_username.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoEllipsis = true;
            this.Btn_Login.Location = new System.Drawing.Point(64, 369);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(181, 28);
            this.Btn_Login.TabIndex = 9;
            this.Btn_Login.Text = "&Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(139, 318);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_pass.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton_Admin);
            this.groupBox1.Controls.Add(this.radioButton_Employee);
            this.groupBox1.Controls.Add(this.radioButton_Company);
            this.groupBox1.Controls.Add(this.radioButton_Citizen);
            this.groupBox1.Controls.Add(this.radioButton_Bank);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(43, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Location = new System.Drawing.Point(96, 76);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(68, 21);
            this.radioButton_Admin.TabIndex = 4;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_Employee
            // 
            this.radioButton_Employee.AutoSize = true;
            this.radioButton_Employee.Location = new System.Drawing.Point(145, 48);
            this.radioButton_Employee.Name = "radioButton_Employee";
            this.radioButton_Employee.Size = new System.Drawing.Size(91, 21);
            this.radioButton_Employee.TabIndex = 3;
            this.radioButton_Employee.TabStop = true;
            this.radioButton_Employee.Text = "Employee";
            this.radioButton_Employee.UseVisualStyleBackColor = true;
            // 
            // radioButton_Company
            // 
            this.radioButton_Company.AutoSize = true;
            this.radioButton_Company.Location = new System.Drawing.Point(22, 49);
            this.radioButton_Company.Name = "radioButton_Company";
            this.radioButton_Company.Size = new System.Drawing.Size(88, 21);
            this.radioButton_Company.TabIndex = 2;
            this.radioButton_Company.TabStop = true;
            this.radioButton_Company.Text = "Company";
            this.radioButton_Company.UseVisualStyleBackColor = true;
            // 
            // radioButton_Citizen
            // 
            this.radioButton_Citizen.AutoSize = true;
            this.radioButton_Citizen.Location = new System.Drawing.Point(145, 21);
            this.radioButton_Citizen.Name = "radioButton_Citizen";
            this.radioButton_Citizen.Size = new System.Drawing.Size(71, 21);
            this.radioButton_Citizen.TabIndex = 1;
            this.radioButton_Citizen.TabStop = true;
            this.radioButton_Citizen.Text = "Citizen";
            this.radioButton_Citizen.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bank
            // 
            this.radioButton_Bank.AutoSize = true;
            this.radioButton_Bank.Location = new System.Drawing.Point(22, 22);
            this.radioButton_Bank.Name = "radioButton_Bank";
            this.radioButton_Bank.Size = new System.Drawing.Size(61, 21);
            this.radioButton_Bank.TabIndex = 0;
            this.radioButton_Bank.TabStop = true;
            this.radioButton_Bank.Text = "Bank";
            this.radioButton_Bank.UseVisualStyleBackColor = true;
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Location = new System.Drawing.Point(246, 439);
            this.Btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(100, 28);
            this.Btn_SignUp.TabIndex = 13;
            this.Btn_SignUp.Text = "Sign Up";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 480);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.RadioButton radioButton_Employee;
        private System.Windows.Forms.RadioButton radioButton_Company;
        private System.Windows.Forms.RadioButton radioButton_Citizen;
        private System.Windows.Forms.RadioButton radioButton_Bank;
        private System.Windows.Forms.Button Btn_SignUp;
    }
}