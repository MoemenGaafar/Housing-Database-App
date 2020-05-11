namespace Housing_Database_Project
{
    partial class ViewTransactions
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
            this.label4 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.ComboBox();
            this.Company = new System.Windows.Forms.ComboBox();
            this.Citizen = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Bank = new System.Windows.Forms.Label();
            this.comboBox_Bank = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paying Citizen ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recieving Company:";
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Items.AddRange(new object[] {
            "Firm",
            "Citizen"});
            this.From.Location = new System.Drawing.Point(174, 26);
            this.From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(108, 24);
            this.From.TabIndex = 4;
            this.From.SelectedIndexChanged += new System.EventHandler(this.From_SelectedIndexChanged);
            // 
            // Company
            // 
            this.Company.FormattingEnabled = true;
            this.Company.Location = new System.Drawing.Point(519, 52);
            this.Company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(108, 24);
            this.Company.TabIndex = 6;
            // 
            // Citizen
            // 
            this.Citizen.Location = new System.Drawing.Point(174, 54);
            this.Citizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Citizen.Name = "Citizen";
            this.Citizen.Size = new System.Drawing.Size(108, 22);
            this.Citizen.TabIndex = 7;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(43, 90);
            this.View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(94, 24);
            this.View.TabIndex = 8;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(624, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // label_Bank
            // 
            this.label_Bank.AutoSize = true;
            this.label_Bank.Location = new System.Drawing.Point(364, 26);
            this.label_Bank.Name = "label_Bank";
            this.label_Bank.Size = new System.Drawing.Size(44, 17);
            this.label_Bank.TabIndex = 10;
            this.label_Bank.Text = "Bank:";
            this.label_Bank.Visible = false;
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Location = new System.Drawing.Point(519, 23);
            this.comboBox_Bank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(108, 24);
            this.comboBox_Bank.TabIndex = 11;
            this.comboBox_Bank.Visible = false;
            this.comboBox_Bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bank_SelectedIndexChanged);
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.comboBox_Bank);
            this.Controls.Add(this.label_Bank);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Citizen);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Load += new System.EventHandler(this.ViewTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox Company;
        private System.Windows.Forms.TextBox Citizen;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Bank;
        private System.Windows.Forms.ComboBox comboBox_Bank;
    }
}