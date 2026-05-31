namespace PL
{
    partial class ctrlInternationalApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblAppID = new Label();
            lblInternationalLicenseID = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Application ID: ";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppID.Location = new Point(185, 0);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(30, 28);
            lblAppID.TabIndex = 1;
            lblAppID.Text = "??";
            // 
            // lblInternationalLicenseID
            // 
            lblInternationalLicenseID.AutoSize = true;
            lblInternationalLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLicenseID.Location = new Point(539, 0);
            lblInternationalLicenseID.Name = "lblInternationalLicenseID";
            lblInternationalLicenseID.Size = new Size(30, 28);
            lblInternationalLicenseID.TabIndex = 2;
            lblInternationalLicenseID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 0);
            label4.Name = "label4";
            label4.Size = new Size(248, 28);
            label4.TabIndex = 3;
            label4.Text = "International License ID: ";
            // 
            // ctrlInternationalApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(label4);
            Controls.Add(lblInternationalLicenseID);
            Controls.Add(lblAppID);
            Controls.Add(label1);
            Name = "ctrlInternationalApplicationInfo";
            Size = new Size(585, 37);
            Load += ctrlInternationalApplicationInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAppID;
        private Label lblInternationalLicenseID;
        private Label label4;
    }
}
