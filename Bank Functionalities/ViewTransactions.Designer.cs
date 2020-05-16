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
            this.label3 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paying Citizen ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recieving Company:";
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Items.AddRange(new object[] {
            "Firm",
            "Citizen"});
            this.From.Location = new System.Drawing.Point(196, 52);
            this.From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(121, 28);
            this.From.TabIndex = 4;
            this.From.SelectedIndexChanged += new System.EventHandler(this.From_SelectedIndexChanged);
            // 
            // Company
            // 
            this.Company.FormattingEnabled = true;
            this.Company.Location = new System.Drawing.Point(584, 85);
            this.Company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(121, 28);
            this.Company.TabIndex = 6;
            // 
            // Citizen
            // 
            this.Citizen.Location = new System.Drawing.Point(196, 88);
            this.Citizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Citizen.Name = "Citizen";
            this.Citizen.Size = new System.Drawing.Size(121, 26);
            this.Citizen.TabIndex = 7;
            // 
            // View
            // 
            this.View.AutoSize = true;
            this.View.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.View.Location = new System.Drawing.Point(48, 132);
            this.View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(53, 30);
            this.View.TabIndex = 8;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(702, 266);
            this.dataGridView1.TabIndex = 9;
            // 
            // label_Bank
            // 
            this.label_Bank.AutoSize = true;
            this.label_Bank.Location = new System.Drawing.Point(410, 52);
            this.label_Bank.Name = "label_Bank";
            this.label_Bank.Size = new System.Drawing.Size(50, 20);
            this.label_Bank.TabIndex = 10;
            this.label_Bank.Text = "Bank:";
            this.label_Bank.Visible = false;
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Location = new System.Drawing.Point(584, 49);
            this.comboBox_Bank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Bank.TabIndex = 11;
            this.comboBox_Bank.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter \"All\" to View All";
            this.label3.Visible = false;
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edit.Location = new System.Drawing.Point(602, 436);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(47, 30);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TID
            // 
            this.TID.FormattingEnabled = true;
            this.TID.Location = new System.Drawing.Point(442, 436);
            this.TID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(154, 28);
            this.TID.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Location = new System.Drawing.Point(231, 436);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(48, 30);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Location = new System.Drawing.Point(655, 434);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(66, 30);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Transactions
            // 
            this.Transactions.AutoSize = true;
            this.Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.Location = new System.Drawing.Point(42, 9);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(147, 26);
            this.Transactions.TabIndex = 17;
            this.Transactions.Text = "Transactions";
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label3);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTransactions_FormClosed);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox TID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Transactions;
    }
}