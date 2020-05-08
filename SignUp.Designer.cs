namespace Housing_Database_Project
{
    partial class SignUp
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
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.TxtBox_PassAgain = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_AccType = new System.Windows.Forms.ComboBox();
            this.acctypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sign Up Form";
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(97, 268);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_pass.TabIndex = 13;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Username.Location = new System.Drawing.Point(20, 155);
            this.label_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(45, 17);
            this.label_Username.TabIndex = 14;
            this.label_Username.Text = "Name";
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.BackColor = System.Drawing.Color.White;
            this.TxtBx_username.Location = new System.Drawing.Point(97, 155);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_username.TabIndex = 12;
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Enabled = false;
            this.Btn_SignUp.Location = new System.Drawing.Point(210, 371);
            this.Btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(100, 28);
            this.Btn_SignUp.TabIndex = 15;
            this.Btn_SignUp.Text = "Sign Up";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // TxtBox_PassAgain
            // 
            this.TxtBox_PassAgain.Location = new System.Drawing.Point(374, 268);
            this.TxtBox_PassAgain.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PassAgain.Name = "TxtBox_PassAgain";
            this.TxtBox_PassAgain.PasswordChar = '*';
            this.TxtBox_PassAgain.Size = new System.Drawing.Size(132, 22);
            this.TxtBox_PassAgain.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(514, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "By checking this box, you give us the permission to sell your soul to the devil.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(257, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password Again";
            // 
            // comboBox_AccType
            // 
            this.comboBox_AccType.FormattingEnabled = true;
            this.comboBox_AccType.Items.AddRange(new object[] {
            "Bank",
            "Citizen",
            "Company",
            "Employee"});
            this.comboBox_AccType.Location = new System.Drawing.Point(178, 107);
            this.comboBox_AccType.Name = "comboBox_AccType";
            this.comboBox_AccType.Size = new System.Drawing.Size(164, 24);
            this.comboBox_AccType.TabIndex = 23;
            this.comboBox_AccType.SelectedIndexChanged += new System.EventHandler(this.comboBox_AccType_SelectedIndexChanged);
            // 
            // acctypeLabel
            // 
            this.acctypeLabel.AutoSize = true;
            this.acctypeLabel.Location = new System.Drawing.Point(196, 87);
            this.acctypeLabel.Name = "acctypeLabel";
            this.acctypeLabel.Size = new System.Drawing.Size(125, 17);
            this.acctypeLabel.TabIndex = 24;
            this.acctypeLabel.Text = "Pick Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 26;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 414);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acctypeLabel);
            this.Controls.Add(this.comboBox_AccType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtBox_PassAgain);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.TxtBx_pass);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.Button Btn_SignUp;
        private System.Windows.Forms.TextBox TxtBox_PassAgain;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_AccType;
        private System.Windows.Forms.Label acctypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}