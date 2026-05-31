namespace PL
{
    partial class frmDetainLicense
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
            ctrlDetainedInfo1 = new ctrlDetainedInfo();
            llHistory = new LinkLabel();
            llLicense = new LinkLabel();
            btnDetain = new Button();
            SuspendLayout();
            // 
            // ctrlFindLicense1
            // 
            ctrlFindLicense1.BackColor = Color.Gray;
            ctrlFindLicense1.Location = new Point(-2, -1);
            ctrlFindLicense1.Name = "ctrlFindLicense1";
            ctrlFindLicense1.Size = new Size(1153, 431);
            ctrlFindLicense1.TabIndex = 0;
            // 
            // ctrlDetainedInfo1
            // 
            ctrlDetainedInfo1.BackColor = Color.Gray;
            ctrlDetainedInfo1.Location = new Point(12, 436);
            ctrlDetainedInfo1.Name = "ctrlDetainedInfo1";
            ctrlDetainedInfo1.Size = new Size(599, 189);
            ctrlDetainedInfo1.TabIndex = 1;
            // 
            // llHistory
            // 
            llHistory.AutoSize = true;
            llHistory.Location = new Point(630, 459);
            llHistory.Name = "llHistory";
            llHistory.Size = new Size(154, 20);
            llHistory.TabIndex = 2;
            llHistory.TabStop = true;
            llHistory.Text = "Show Licenses History";
            llHistory.LinkClicked += llHistory_LinkClicked;
            // 
            // llLicense
            // 
            llLicense.AutoSize = true;
            llLicense.Location = new Point(630, 489);
            llLicense.Name = "llLicense";
            llLicense.Size = new Size(147, 20);
            llLicense.TabIndex = 3;
            llLicense.TabStop = true;
            llLicense.Text = "Show License Details";
            llLicense.LinkClicked += llLicense_LinkClicked;
            // 
            // btnDetain
            // 
            btnDetain.Location = new Point(630, 534);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(94, 29);
            btnDetain.TabIndex = 4;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1514, 637);
            Controls.Add(btnDetain);
            Controls.Add(llLicense);
            Controls.Add(llHistory);
            Controls.Add(ctrlDetainedInfo1);
            Controls.Add(ctrlFindLicense1);
            Name = "frmDetainLicense";
            Text = "frmDetainLicense";
            Load += frmDetainLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlFindLicense ctrlFindLicense1;
        private ctrlDetainedInfo ctrlDetainedInfo1;
        private LinkLabel llHistory;
        private LinkLabel llLicense;
        private Button btnDetain;
    }
}