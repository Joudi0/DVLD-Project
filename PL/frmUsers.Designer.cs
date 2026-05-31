namespace PL
{
    partial class frmUsers
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
            components = new System.ComponentModel.Container();
            cmsUsers = new ContextMenuStrip(components);
            showUserToolStripMenuItem = new ToolStripMenuItem();
            updateUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            dgv = new DataGridView();
            lblRecords = new Label();
            label1 = new Label();
            btnAddNewuser = new Button();
            btnClose = new Button();
            tbFilter = new TextBox();
            cb = new ComboBox();
            chbIsActive = new CheckBox();
            pictureBox1 = new PictureBox();
            cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmsUsers
            // 
            cmsUsers.ImageScalingSize = new Size(20, 20);
            cmsUsers.Items.AddRange(new ToolStripItem[] { showUserToolStripMenuItem, updateUserToolStripMenuItem, deleteUserToolStripMenuItem });
            cmsUsers.Name = "cmsUsers";
            cmsUsers.Size = new Size(156, 76);
            // 
            // showUserToolStripMenuItem
            // 
            showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            showUserToolStripMenuItem.Size = new Size(155, 24);
            showUserToolStripMenuItem.Text = "Show User";
            showUserToolStripMenuItem.Click += showUserToolStripMenuItem_Click;
            // 
            // updateUserToolStripMenuItem
            // 
            updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            updateUserToolStripMenuItem.Size = new Size(155, 24);
            updateUserToolStripMenuItem.Text = "Edit User";
            updateUserToolStripMenuItem.Click += updateUserToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(155, 24);
            deleteUserToolStripMenuItem.Text = "Delete User";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = cmsUsers;
            dgv.Location = new Point(1, 216);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1479, 222);
            dgv.TabIndex = 1;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(123, 448);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(30, 28);
            lblRecords.TabIndex = 2;
            lblRecords.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 448);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 3;
            label1.Text = "# Records: ";
            // 
            // btnAddNewuser
            // 
            btnAddNewuser.Location = new Point(1364, 111);
            btnAddNewuser.Name = "btnAddNewuser";
            btnAddNewuser.Size = new Size(94, 29);
            btnAddNewuser.TabIndex = 4;
            btnAddNewuser.Text = "Add";
            btnAddNewuser.UseVisualStyleBackColor = true;
            btnAddNewuser.Click += btnAddNewuser_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1364, 448);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(200, 159);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(125, 27);
            tbFilter.TabIndex = 9;
            tbFilter.Visible = false;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // cb
            // 
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "None", "UserID", "UserName", "PersonID", "FullName", "isActive" });
            cb.Location = new Point(12, 157);
            cb.Name = "cb";
            cb.Size = new Size(151, 28);
            cb.TabIndex = 8;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.Location = new Point(200, 161);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(86, 24);
            chbIsActive.TabIndex = 10;
            chbIsActive.Text = "Is Active";
            chbIsActive.UseVisualStyleBackColor = true;
            chbIsActive.Visible = false;
            chbIsActive.CheckedChanged += chbIsActive_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.users;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1479, 485);
            Controls.Add(pictureBox1);
            Controls.Add(chbIsActive);
            Controls.Add(tbFilter);
            Controls.Add(cb);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewuser);
            Controls.Add(label1);
            Controls.Add(lblRecords);
            Controls.Add(dgv);
            Name = "frmUsers";
            Text = "frmUsers";
            Load += frmUsers_Load;
            cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip cmsUsers;
        private ToolStripMenuItem showUserToolStripMenuItem;
        private ToolStripMenuItem updateUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private DataGridView dgv;
        private Label lblRecords;
        private Label label1;
        private Button btnAddNewuser;
        private Button btnClose;
        private TextBox tbFilter;
        private ComboBox cb;
        private CheckBox chbIsActive;
        private PictureBox pictureBox1;
    }
}