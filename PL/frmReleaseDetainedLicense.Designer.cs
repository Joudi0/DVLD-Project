namespace PL
{
    partial class frmReleaseDetainedLicense
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
            btnRelease = new Button();
            llLicense = new LinkLabel();
            llHistory = new LinkLabel();
            ctrlDetainedInfo1 = new ctrlDetainedInfo();
            ctrlFindLicense1 = new ctrlFindLicense();
            btnCheck = new Button();
            lblApplicationFees = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(644, 538);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(94, 29);
            btnRelease.TabIndex = 9;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // llLicense
            // 
            llLicense.AutoSize = true;
            llLicense.Location = new Point(644, 493);
            llLicense.Name = "llLicense";
            llLicense.Size = new Size(147, 20);
            llLicense.TabIndex = 8;
            llLicense.TabStop = true;
            llLicense.Text = "Show License Details";
            // 
            // llHistory
            // 
            llHistory.AutoSize = true;
            llHistory.Location = new Point(644, 463);
            llHistory.Name = "llHistory";
            llHistory.Size = new Size(154, 20);
            llHistory.TabIndex = 7;
            llHistory.TabStop = true;
            llHistory.Text = "Show Licenses History";
            // 
            // ctrlDetainedInfo1
            // 
            ctrlDetainedInfo1.BackColor = Color.Gray;
            ctrlDetainedInfo1.Location = new Point(26, 440);
            ctrlDetainedInfo1.Name = "ctrlDetainedInfo1";
            ctrlDetainedInfo1.Size = new Size(599, 189);
            ctrlDetainedInfo1.TabIndex = 6;
            // 
            // ctrlFindLicense1
            // 
            ctrlFindLicense1.BackColor = Color.Gray;
            ctrlFindLicense1.Location = new Point(12, 3);
            ctrlFindLicense1.Name = "ctrlFindLicense1";
            ctrlFindLicense1.Size = new Size(1153, 431);
            ctrlFindLicense1.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(449, 12);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(134, 31);
            btnCheck.TabIndex = 10;
            btnCheck.Text = "Check if Detained";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApplicationFees.Location = new Point(214, 632);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(30, 28);
            lblApplicationFees.TabIndex = 11;
            lblApplicationFees.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(26, 632);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 12;
            label1.Text = "Application Fees:";
            // 
            // frmReleaseDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1500, 697);
            Controls.Add(label1);
            Controls.Add(lblApplicationFees);
            Controls.Add(btnCheck);
            Controls.Add(btnRelease);
            Controls.Add(llLicense);
            Controls.Add(llHistory);
            Controls.Add(ctrlDetainedInfo1);
            Controls.Add(ctrlFindLicense1);
            Name = "frmReleaseDetainedLicense";
            Text = "frmReleaseDetainedLicense";
            Load += frmReleaseDetainedLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRelease;
        private LinkLabel llLicense;
        private LinkLabel llHistory;
        private ctrlDetainedInfo ctrlDetainedInfo1;
        private ctrlFindLicense ctrlFindLicense1;
        private Button btnCheck;
        private Label lblApplicationFees;
        private Label label1;
    }
}