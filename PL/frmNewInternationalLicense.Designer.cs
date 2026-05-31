namespace PL
{
    partial class frmNewInternationalLicense
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
            ctrlFindLicense1 = new ctrlFindLicense();
            ctrlInternationalApplicationInfo1 = new ctrlInternationalApplicationInfo();
            btnIssue = new Button();
            llHistory = new LinkLabel();
            llShowiLicense = new LinkLabel();
            SuspendLayout();
            // 
            // ctrlFindLicense1
            // 
            ctrlFindLicense1.BackColor = Color.Gray;
            ctrlFindLicense1.Location = new Point(0, -1);
            ctrlFindLicense1.Name = "ctrlFindLicense1";
            ctrlFindLicense1.Size = new Size(1153, 433);
            ctrlFindLicense1.TabIndex = 0;
            // 
            // ctrlInternationalApplicationInfo1
            // 
            ctrlInternationalApplicationInfo1.BackColor = Color.Gray;
            ctrlInternationalApplicationInfo1.Location = new Point(22, 438);
            ctrlInternationalApplicationInfo1.Name = "ctrlInternationalApplicationInfo1";
            ctrlInternationalApplicationInfo1.Size = new Size(616, 46);
            ctrlInternationalApplicationInfo1.TabIndex = 1;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(991, 438);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click_1;
            // 
            // llHistory
            // 
            llHistory.AutoSize = true;
            llHistory.Location = new Point(36, 502);
            llHistory.Name = "llHistory";
            llHistory.Size = new Size(114, 20);
            llHistory.TabIndex = 3;
            llHistory.TabStop = true;
            llHistory.Text = "Licenses History";
            llHistory.LinkClicked += llHistory_LinkClicked;
            // 
            // llShowiLicense
            // 
            llShowiLicense.AutoSize = true;
            llShowiLicense.Enabled = false;
            llShowiLicense.Location = new Point(176, 502);
            llShowiLicense.Name = "llShowiLicense";
            llShowiLicense.Size = new Size(185, 20);
            llShowiLicense.TabIndex = 4;
            llShowiLicense.TabStop = true;
            llShowiLicense.Text = "Show International License";
            llShowiLicense.LinkClicked += llShowiLicense_LinkClicked;
            // 
            // frmNewInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1156, 571);
            Controls.Add(llShowiLicense);
            Controls.Add(llHistory);
            Controls.Add(btnIssue);
            Controls.Add(ctrlInternationalApplicationInfo1);
            Controls.Add(ctrlFindLicense1);
            Name = "frmNewInternationalLicense";
            Text = "frmNewInternationalLicense";
            Load += frmNewInternationalLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlFindLicense ctrlFindLicense1;
        private ctrlInternationalApplicationInfo ctrlInternationalApplicationInfo1;
        private Button btnIssue;
        private LinkLabel llHistory;
        private LinkLabel llShowiLicense;
    }
}