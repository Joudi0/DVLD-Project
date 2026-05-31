namespace PL
{
    partial class ctrlUserInfo
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
            ctrlPersonInfo1 = new ctrlPersonInfo();
            label1 = new Label();
            lblUsername = new Label();
            linklblEditUser = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            lblState = new Label();
            lblUserID = new Label();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.Gray;
            ctrlPersonInfo1.Location = new Point(3, 3);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(858, 473);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(377, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "??";
            // 
            // linklblEditUser
            // 
            linklblEditUser.AutoSize = true;
            linklblEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklblEditUser.Location = new Point(687, 28);
            linklblEditUser.Name = "linklblEditUser";
            linklblEditUser.Size = new Size(106, 28);
            linklblEditUser.TabIndex = 3;
            linklblEditUser.TabStop = true;
            linklblEditUser.Text = "Edit User?";
            linklblEditUser.LinkClicked += linklblEditUser_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(495, 28);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 4;
            label2.Text = "State:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 28);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 5;
            label3.Text = "User ID:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(588, 28);
            lblState.Name = "lblState";
            lblState.Size = new Size(30, 28);
            lblState.TabIndex = 6;
            lblState.Text = "??";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(151, 28);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(30, 28);
            lblUserID.TabIndex = 7;
            lblUserID.Text = "??";
            // 
            // ctrlUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblUserID);
            Controls.Add(lblState);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linklblEditUser);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(ctrlPersonInfo1);
            Name = "ctrlUserInfo";
            Size = new Size(864, 482);
            Load += ctrlUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private Label label1;
        private Label lblUsername;
        private LinkLabel linklblEditUser;
        private Label label2;
        private Label label3;
        private Label lblState;
        private Label lblUserID;
    }
}
