namespace Housing_Database_Project
{
    partial class ViewBanks
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
            this.Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BankName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewTrans = new System.Windows.Forms.Button();
            this.NewTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(323, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(148, 32);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Bank";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BankName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 81);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // BankName
            // 
            this.BankName.FormattingEnabled = true;
            this.BankName.Location = new System.Drawing.Point(100, 33);
            this.BankName.Name = "BankName";
            this.BankName.Size = new System.Drawing.Size(146, 28);
            this.BankName.TabIndex = 1;
            this.BankName.SelectedIndexChanged += new System.EventHandler(this.BankName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bank Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(573, 330);
            this.dataGridView1.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(323, 100);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(148, 33);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete Bank";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.ViewTrans);
            this.groupBox1.Controls.Add(this.NewTrans);
            this.groupBox1.Location = new System.Drawing.Point(18, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Bank";
            // 
            // ViewTrans
            // 
            this.ViewTrans.Location = new System.Drawing.Point(167, 37);
            this.ViewTrans.Name = "ViewTrans";
            this.ViewTrans.Size = new System.Drawing.Size(183, 33);
            this.ViewTrans.TabIndex = 3;
            this.ViewTrans.Text = "View Transactions";
            this.ViewTrans.UseVisualStyleBackColor = true;
            this.ViewTrans.Click += new System.EventHandler(this.ViewTrans_Click);
            // 
            // NewTrans
            // 
            this.NewTrans.Location = new System.Drawing.Point(368, 37);
            this.NewTrans.Name = "NewTrans";
            this.NewTrans.Size = new System.Drawing.Size(157, 33);
            this.NewTrans.TabIndex = 4;
            this.NewTrans.Text = "New Transaction";
            this.NewTrans.UseVisualStyleBackColor = true;
            this.NewTrans.Click += new System.EventHandler(this.NewTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Involved Banks";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(13, 37);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(148, 33);
            this.Info.TabIndex = 15;
            this.Info.Text = "Bank Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // ViewBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Name = "ViewBanks";
            this.Text = "ViewBanks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewBanks_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox BankName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ViewTrans;
        private System.Windows.Forms.Button NewTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Info;
    }
}