namespace Housing_Database_Project.Company_Functionalities
{
    partial class SetBiddingPrice
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
            this.button_Bid = new System.Windows.Forms.Button();
            this.textBox_BiddingPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ProjID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Bid
            // 
            this.button_Bid.Location = new System.Drawing.Point(96, 116);
            this.button_Bid.Name = "button_Bid";
            this.button_Bid.Size = new System.Drawing.Size(94, 27);
            this.button_Bid.TabIndex = 13;
            this.button_Bid.Text = "Bid";
            this.button_Bid.UseVisualStyleBackColor = true;
            this.button_Bid.Click += new System.EventHandler(this.button_Bid_Click);
            // 
            // textBox_BiddingPrice
            // 
            this.textBox_BiddingPrice.Location = new System.Drawing.Point(135, 67);
            this.textBox_BiddingPrice.Name = "textBox_BiddingPrice";
            this.textBox_BiddingPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox_BiddingPrice.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bidding Price";
            // 
            // label_ProjID
            // 
            this.label_ProjID.AutoSize = true;
            this.label_ProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProjID.ForeColor = System.Drawing.Color.Red;
            this.label_ProjID.Location = new System.Drawing.Point(194, 21);
            this.label_ProjID.Name = "label_ProjID";
            this.label_ProjID.Size = new System.Drawing.Size(53, 20);
            this.label_ProjID.TabIndex = 8;
            this.label_ProjID.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Applying to Project:";
            // 
            // SetBiddingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 155);
            this.Controls.Add(this.button_Bid);
            this.Controls.Add(this.textBox_BiddingPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ProjID);
            this.Controls.Add(this.label1);
            this.Name = "SetBiddingPrice";
            this.Text = "SetBiddingPrice";
            this.Load += new System.EventHandler(this.SetBiddingPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Bid;
        private System.Windows.Forms.TextBox textBox_BiddingPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ProjID;
        private System.Windows.Forms.Label label1;
    }
}