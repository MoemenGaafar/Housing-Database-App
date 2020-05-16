namespace Housing_Database_Project
{
    partial class CitizenPayments
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
            this.View = new System.Windows.Forms.Button();
            this.ProjectView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BankView = new System.Windows.Forms.ComboBox();
            this.UnitView = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CitizenID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(665, 402);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(108, 30);
            this.View.TabIndex = 19;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // ProjectView
            // 
            this.ProjectView.FormattingEnabled = true;
            this.ProjectView.Location = new System.Drawing.Point(299, 404);
            this.ProjectView.Name = "ProjectView";
            this.ProjectView.Size = new System.Drawing.Size(121, 28);
            this.ProjectView.TabIndex = 17;
            this.ProjectView.SelectedIndexChanged += new System.EventHandler(this.ProjectView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bank:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placed Payments:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 462);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(840, 249);
            this.dataGridView2.TabIndex = 12;
            // 
            // BankView
            // 
            this.BankView.FormattingEnabled = true;
            this.BankView.Location = new System.Drawing.Point(79, 404);
            this.BankView.Name = "BankView";
            this.BankView.Size = new System.Drawing.Size(121, 28);
            this.BankView.TabIndex = 20;
            // 
            // UnitView
            // 
            this.UnitView.FormattingEnabled = true;
            this.UnitView.Location = new System.Drawing.Point(525, 404);
            this.UnitView.Name = "UnitView";
            this.UnitView.Size = new System.Drawing.Size(121, 28);
            this.UnitView.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Unit:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(844, 249);
            this.dataGridView1.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Claimed Units";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Units and Payments";
            // 
            // CitizenID
            // 
            this.CitizenID.AutoSize = true;
            this.CitizenID.Location = new System.Drawing.Point(28, 44);
            this.CitizenID.Name = "CitizenID";
            this.CitizenID.Size = new System.Drawing.Size(13, 20);
            this.CitizenID.TabIndex = 40;
            this.CitizenID.Text = " ";
            // 
            // CitizenPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 745);
            this.Controls.Add(this.CitizenID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UnitView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BankView);
            this.Controls.Add(this.View);
            this.Controls.Add(this.ProjectView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "CitizenPayments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CitizenPayments_FormClosed);
            this.Load += new System.EventHandler(this.CitizenPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View;
        private System.Windows.Forms.ComboBox ProjectView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox BankView;
        private System.Windows.Forms.ComboBox UnitView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CitizenID;
    }
}