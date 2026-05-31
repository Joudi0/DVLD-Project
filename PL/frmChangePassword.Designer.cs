namespace PL
{
    partial class frmChangePassword
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
            ctrlUserInfo1 = new ctrlUserInfo();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNewPasswordAgain = new TextBox();
            tbNewPassword = new TextBox();
            tbOldPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.BackColor = Color.Gray;
            ctrlUserInfo1.Location = new Point(-3, -1);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(1115, 460);
            ctrlUserInfo1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(741, 230);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 2;
            label2.Text = "Current Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(741, 287);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 3;
            label3.Text = "New Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(741, 337);
            label4.Name = "label4";
            label4.Size = new Size(243, 28);
            label4.TabIndex = 4;
            label4.Text = "Re-Enter New Password:";
            // 
            // tbNewPasswordAgain
            // 
            tbNewPasswordAgain.Location = new Point(987, 341);
            tbNewPasswordAgain.Name = "tbNewPasswordAgain";
            tbNewPasswordAgain.PasswordChar = '*';
            tbNewPasswordAgain.Size = new Size(125, 27);
            tbNewPasswordAgain.TabIndex = 6;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(987, 291);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(125, 27);
            tbNewPassword.TabIndex = 7;
            // 
            // tbOldPassword
            // 
            tbOldPassword.Location = new Point(987, 230);
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.PasswordChar = '*';
            tbOldPassword.Size = new Size(125, 27);
            tbOldPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(959, 389);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 9;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1147, 450);
            Controls.Add(button1);
            Controls.Add(tbOldPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(tbNewPasswordAgain);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ctrlUserInfo1);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNewPasswordAgain;
        private TextBox tbNewPassword;
        private TextBox tbOldPassword;
        private Button button1;
    }
}