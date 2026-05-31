namespace PL
{
    partial class ctrlAddUpdateUser
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
            tabControl1 = new TabControl();
            tpPerson = new TabPage();
            btnAddPerson = new Button();
            ctrlPersonInfoFilter1 = new ctrlPersonInfoFilter();
            tpUser = new TabPage();
            linklblChangePassword = new LinkLabel();
            chbIsActive = new CheckBox();
            button1 = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbPasswordConfirm = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            tabControl1.SuspendLayout();
            tpPerson.SuspendLayout();
            tpUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPerson);
            tabControl1.Controls.Add(tpUser);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 705);
            tabControl1.TabIndex = 0;
            // 
            // tpPerson
            // 
            tpPerson.BackColor = Color.Gray;
            tpPerson.Controls.Add(btnAddPerson);
            tpPerson.Controls.Add(ctrlPersonInfoFilter1);
            tpPerson.Location = new Point(4, 29);
            tpPerson.Name = "tpPerson";
            tpPerson.Padding = new Padding(3);
            tpPerson.Size = new Size(1063, 672);
            tpPerson.TabIndex = 0;
            tpPerson.Text = "Person";
            tpPerson.Click += tpPerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(26, 62);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(94, 29);
            btnAddPerson.TabIndex = 1;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // ctrlPersonInfoFilter1
            // 
            ctrlPersonInfoFilter1.BackColor = Color.Gray;
            ctrlPersonInfoFilter1.Location = new Point(-7, 62);
            ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            ctrlPersonInfoFilter1.Size = new Size(985, 611);
            ctrlPersonInfoFilter1.TabIndex = 0;
            // 
            // tpUser
            // 
            tpUser.BackColor = Color.Gray;
            tpUser.Controls.Add(linklblChangePassword);
            tpUser.Controls.Add(chbIsActive);
            tpUser.Controls.Add(button1);
            tpUser.Controls.Add(tbUsername);
            tpUser.Controls.Add(tbPassword);
            tpUser.Controls.Add(tbPasswordConfirm);
            tpUser.Controls.Add(label4);
            tpUser.Controls.Add(label3);
            tpUser.Controls.Add(label2);
            tpUser.Location = new Point(4, 29);
            tpUser.Name = "tpUser";
            tpUser.Padding = new Padding(3);
            tpUser.Size = new Size(1063, 672);
            tpUser.TabIndex = 1;
            tpUser.Text = "User";
            tpUser.Click += tpUser_Click;
            // 
            // linklblChangePassword
            // 
            linklblChangePassword.AutoSize = true;
            linklblChangePassword.Location = new Point(735, 68);
            linklblChangePassword.Name = "linklblChangePassword";
            linklblChangePassword.Size = new Size(124, 20);
            linklblChangePassword.TabIndex = 18;
            linklblChangePassword.TabStop = true;
            linklblChangePassword.Text = "Change Password";
            linklblChangePassword.Visible = false;
            linklblChangePassword.LinkClicked += linklblChangePassword_LinkClicked;
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.Location = new Point(328, 249);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(86, 24);
            chbIsActive.TabIndex = 17;
            chbIsActive.Text = "Is Active";
            chbIsActive.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(550, 249);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 16;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(574, 65);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(125, 27);
            tbUsername.TabIndex = 15;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(574, 126);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 14;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Location = new Point(574, 176);
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.PasswordChar = '*';
            tbPasswordConfirm.Size = new Size(125, 27);
            tbPasswordConfirm.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(328, 172);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 12;
            label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 122);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 11;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 65);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 10;
            label2.Text = "Username:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(449, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add New User";
            // 
            // ctrlAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            Name = "ctrlAddUpdateUser";
            Size = new Size(1122, 705);
            Load += ctrlAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tpPerson.ResumeLayout(false);
            tpUser.ResumeLayout(false);
            tpUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpPerson;
        private TabPage tpUser;
        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
        private Button button1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbPasswordConfirm;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chbIsActive;
        private Label lblTitle;
        private LinkLabel linklblChangePassword;
        private Button btnAddPerson;
    }
}
