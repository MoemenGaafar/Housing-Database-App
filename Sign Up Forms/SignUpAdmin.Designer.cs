namespace Housing_Database_Project.Sign_Up_Forms
{
    partial class SignUpAdmin
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
            this.Verify = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.Access = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Devil = new System.Windows.Forms.CheckBox();
            this.textBox_PassAgain = new System.Windows.Forms.TextBox();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Verify.Location = new System.Drawing.Point(268, 132);
            this.Verify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(59, 30);
            this.Verify.TabIndex = 84;
            this.Verify.Text = "Verify";
            this.Verify.UseVisualStyleBackColor = true;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L1.Location = new System.Drawing.Point(21, 97);
            this.L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(410, 20);
            this.L1.TabIndex = 83;
            this.L1.Text = "Please enter the access code provided to you by the firm:";
            // 
            // Access
            // 
            this.Access.Location = new System.Drawing.Point(453, 97);
            this.Access.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Access.Name = "Access";
            this.Access.PasswordChar = '*';
            this.Access.Size = new System.Drawing.Size(148, 26);
            this.Access.TabIndex = 82;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(125, 121);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(148, 26);
            this.textBox_Name.TabIndex = 81;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(37, 121);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 80;
            this.label_Name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(323, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Password Again";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Password";
            // 
            // checkBox_Devil
            // 
            this.checkBox_Devil.AutoSize = true;
            this.checkBox_Devil.Location = new System.Drawing.Point(25, 272);
            this.checkBox_Devil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Devil.Name = "checkBox_Devil";
            this.checkBox_Devil.Size = new System.Drawing.Size(567, 24);
            this.checkBox_Devil.TabIndex = 75;
            this.checkBox_Devil.Text = "By checking this box, you give us the permission to sell your soul to the devil.";
            this.checkBox_Devil.UseVisualStyleBackColor = true;
            this.checkBox_Devil.CheckedChanged += new System.EventHandler(this.checkBox_Devil_CheckedChanged);
            // 
            // textBox_PassAgain
            // 
            this.textBox_PassAgain.Location = new System.Drawing.Point(455, 195);
            this.textBox_PassAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_PassAgain.Name = "textBox_PassAgain";
            this.textBox_PassAgain.PasswordChar = '*';
            this.textBox_PassAgain.Size = new System.Drawing.Size(148, 26);
            this.textBox_PassAgain.TabIndex = 74;
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Enabled = false;
            this.Btn_SignUp.Location = new System.Drawing.Point(248, 318);
            this.Btn_SignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(112, 35);
            this.Btn_SignUp.TabIndex = 73;
            this.Btn_SignUp.Text = "Sign Up";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(125, 202);
            this.textBox_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.Size = new System.Drawing.Size(148, 26);
            this.textBox_Pass.TabIndex = 72;
            // 
            // button_Back
            // 
            this.button_Back.AutoSize = true;
            this.button_Back.Location = new System.Drawing.Point(37, 39);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(84, 30);
            this.button_Back.TabIndex = 71;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(180, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 36);
            this.title.TabIndex = 70;
            this.title.Text = "Admin Sign Up Form";
            // 
            // SignUpAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 371);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Access);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Devil);
            this.Controls.Add(this.textBox_PassAgain);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.title);
            this.Name = "SignUpAdmin";
            this.Text = "SignUpAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox Access;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Devil;
        private System.Windows.Forms.TextBox textBox_PassAgain;
        private System.Windows.Forms.Button Btn_SignUp;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label title;
    }
}