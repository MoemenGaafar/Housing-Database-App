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
            this.comboBox_AccType = new System.Windows.Forms.ComboBox();
            this.acctypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sign Up Form";
            // 
            // comboBox_AccType
            // 
            this.comboBox_AccType.FormattingEnabled = true;
            this.comboBox_AccType.Items.AddRange(new object[] {
            "Bank",
            "Citizen",
            "Company",
            "Employee"});
            this.comboBox_AccType.Location = new System.Drawing.Point(39, 89);
            this.comboBox_AccType.Name = "comboBox_AccType";
            this.comboBox_AccType.Size = new System.Drawing.Size(164, 24);
            this.comboBox_AccType.TabIndex = 23;
            this.comboBox_AccType.SelectedIndexChanged += new System.EventHandler(this.comboBox_AccType_SelectedIndexChanged);
            // 
            // acctypeLabel
            // 
            this.acctypeLabel.AutoSize = true;
            this.acctypeLabel.Location = new System.Drawing.Point(57, 69);
            this.acctypeLabel.Name = "acctypeLabel";
            this.acctypeLabel.Size = new System.Drawing.Size(125, 17);
            this.acctypeLabel.TabIndex = 24;
            this.acctypeLabel.Text = "Pick Account Type";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 142);
            this.Controls.Add(this.acctypeLabel);
            this.Controls.Add(this.comboBox_AccType);
            this.Controls.Add(this.label4);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_AccType;
        private System.Windows.Forms.Label acctypeLabel;
    }
}