namespace Housing_Database_Project
{
    partial class ProjectsEmployeeFunctionalities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsEmployeeFunctionalities));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.button_ViewProjs = new System.Windows.Forms.Button();
            this.button_ViewApps = new System.Windows.Forms.Button();
            this.button_ViewTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(119, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Slave";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(13, 439);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(100, 28);
            this.Btn_LogOut.TabIndex = 13;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // button_ViewProjs
            // 
            this.button_ViewProjs.Location = new System.Drawing.Point(204, 113);
            this.button_ViewProjs.Name = "button_ViewProjs";
            this.button_ViewProjs.Size = new System.Drawing.Size(143, 31);
            this.button_ViewProjs.TabIndex = 14;
            this.button_ViewProjs.Text = "View Projects";
            this.button_ViewProjs.UseVisualStyleBackColor = true;
            this.button_ViewProjs.Click += new System.EventHandler(this.button_ViewProjs_Click);
            // 
            // button_ViewApps
            // 
            this.button_ViewApps.Location = new System.Drawing.Point(204, 170);
            this.button_ViewApps.Name = "button_ViewApps";
            this.button_ViewApps.Size = new System.Drawing.Size(143, 31);
            this.button_ViewApps.TabIndex = 15;
            this.button_ViewApps.Text = "View Applications";
            this.button_ViewApps.UseVisualStyleBackColor = true;
            // 
            // button_ViewTrans
            // 
            this.button_ViewTrans.Location = new System.Drawing.Point(204, 229);
            this.button_ViewTrans.Name = "button_ViewTrans";
            this.button_ViewTrans.Size = new System.Drawing.Size(143, 31);
            this.button_ViewTrans.TabIndex = 16;
            this.button_ViewTrans.Text = "View Transactions";
            this.button_ViewTrans.UseVisualStyleBackColor = true;
            // 
            // ProjectsEmployeeFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 480);
            this.Controls.Add(this.button_ViewTrans);
            this.Controls.Add(this.button_ViewApps);
            this.Controls.Add(this.button_ViewProjs);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.label1);
            this.Name = "ProjectsEmployeeFunctionalities";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ProjectsEmployeeFunctionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectsEmployeeFunctionalities_FormClosed);
            this.Load += new System.EventHandler(this.ProjectsEmployeeFunctionalities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button button_ViewProjs;
        private System.Windows.Forms.Button button_ViewApps;
        private System.Windows.Forms.Button button_ViewTrans;
    }
}