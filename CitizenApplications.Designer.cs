namespace Housing_Database_Project
{
    partial class CitizenApplications
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.ProjectDelete = new System.Windows.Forms.ComboBox();
            this.UnitDelete = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Claim = new System.Windows.Forms.Button();
            this.ProjectAccept = new System.Windows.Forms.ComboBox();
            this.UnitAccept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GiveUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(481, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(481, 184);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accepted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delete:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Claim/ Give up:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(708, 203);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 30);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ProjectDelete
            // 
            this.ProjectDelete.FormattingEnabled = true;
            this.ProjectDelete.Location = new System.Drawing.Point(708, 117);
            this.ProjectDelete.Name = "ProjectDelete";
            this.ProjectDelete.Size = new System.Drawing.Size(121, 28);
            this.ProjectDelete.TabIndex = 16;
            // 
            // UnitDelete
            // 
            this.UnitDelete.FormattingEnabled = true;
            this.UnitDelete.Location = new System.Drawing.Point(708, 154);
            this.UnitDelete.Name = "UnitDelete";
            this.UnitDelete.Size = new System.Drawing.Size(121, 28);
            this.UnitDelete.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Project";
            // 
            // Claim
            // 
            this.Claim.Location = new System.Drawing.Point(542, 396);
            this.Claim.Name = "Claim";
            this.Claim.Size = new System.Drawing.Size(108, 30);
            this.Claim.TabIndex = 22;
            this.Claim.Text = "Claim";
            this.Claim.UseVisualStyleBackColor = true;
            this.Claim.Click += new System.EventHandler(this.Claim_Click);
            // 
            // ProjectAccept
            // 
            this.ProjectAccept.FormattingEnabled = true;
            this.ProjectAccept.Location = new System.Drawing.Point(695, 305);
            this.ProjectAccept.Name = "ProjectAccept";
            this.ProjectAccept.Size = new System.Drawing.Size(121, 28);
            this.ProjectAccept.TabIndex = 21;
            // 
            // UnitAccept
            // 
            this.UnitAccept.FormattingEnabled = true;
            this.UnitAccept.Location = new System.Drawing.Point(695, 342);
            this.UnitAccept.Name = "UnitAccept";
            this.UnitAccept.Size = new System.Drawing.Size(121, 28);
            this.UnitAccept.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Unit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Project";
            // 
            // GiveUp
            // 
            this.GiveUp.Location = new System.Drawing.Point(708, 396);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(108, 30);
            this.GiveUp.TabIndex = 23;
            this.GiveUp.Text = "Give Up";
            this.GiveUp.UseVisualStyleBackColor = true;
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "Manage Payments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CitizenApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GiveUp);
            this.Controls.Add(this.Claim);
            this.Controls.Add(this.ProjectAccept);
            this.Controls.Add(this.UnitAccept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ProjectDelete);
            this.Controls.Add(this.UnitDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CitizenApplications";
            this.Text = "CitizenApplications";
            this.Load += new System.EventHandler(this.CitizenApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox ProjectDelete;
        private System.Windows.Forms.ComboBox UnitDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Claim;
        private System.Windows.Forms.ComboBox ProjectAccept;
        private System.Windows.Forms.ComboBox UnitAccept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GiveUp;
        private System.Windows.Forms.Button button1;
    }
}