namespace PL
{
    partial class frmManageDetainedLicenses
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
            dgv = new DataGridView();
            cms = new ContextMenuStrip(components);
            showPersonDetailesToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailesToolStripMenuItem = new ToolStripMenuItem();
            showLicensesHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblRecords = new Label();
            btnClose = new Button();
            btnDetain = new Button();
            btnRelease = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = cms;
            dgv.Location = new Point(2, 210);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1289, 188);
            dgv.TabIndex = 0;
            dgv.RowContextMenuStripNeeded += dgv_RowContextMenuStripNeeded;
            // 
            // cms
            // 
            cms.ImageScalingSize = new Size(20, 20);
            cms.Items.AddRange(new ToolStripItem[] { showPersonDetailesToolStripMenuItem, showLicenseDetailesToolStripMenuItem, showLicensesHistoryToolStripMenuItem, releaseToolStripMenuItem });
            cms.Name = "contextMenuStrip1";
            cms.Size = new Size(225, 100);
            // 
            // showPersonDetailesToolStripMenuItem
            // 
            showPersonDetailesToolStripMenuItem.Name = "showPersonDetailesToolStripMenuItem";
            showPersonDetailesToolStripMenuItem.Size = new Size(224, 24);
            showPersonDetailesToolStripMenuItem.Text = "Show Person Detailes";
            showPersonDetailesToolStripMenuItem.Click += showPersonDetailesToolStripMenuItem_Click;
            // 
            // showLicenseDetailesToolStripMenuItem
            // 
            showLicenseDetailesToolStripMenuItem.Name = "showLicenseDetailesToolStripMenuItem";
            showLicenseDetailesToolStripMenuItem.Size = new Size(224, 24);
            showLicenseDetailesToolStripMenuItem.Text = "Show License Detailes";
            showLicenseDetailesToolStripMenuItem.Click += showLicenseDetailesToolStripMenuItem_Click;
            // 
            // showLicensesHistoryToolStripMenuItem
            // 
            showLicensesHistoryToolStripMenuItem.Name = "showLicensesHistoryToolStripMenuItem";
            showLicensesHistoryToolStripMenuItem.Size = new Size(224, 24);
            showLicensesHistoryToolStripMenuItem.Text = "Show Licenses History";
            showLicensesHistoryToolStripMenuItem.Click += showLicensesHistoryToolStripMenuItem_Click;
            // 
            // releaseToolStripMenuItem
            // 
            releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            releaseToolStripMenuItem.Size = new Size(224, 24);
            releaseToolStripMenuItem.Text = "Release";
            releaseToolStripMenuItem.Click += releaseToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 414);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 1;
            label1.Text = "# Records: ";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(150, 414);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(30, 28);
            lblRecords.TabIndex = 2;
            lblRecords.Text = "??";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1118, 413);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDetain
            // 
            btnDetain.Location = new Point(1041, 143);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(94, 29);
            btnDetain.TabIndex = 4;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(1159, 143);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(94, 29);
            btnRelease.TabIndex = 5;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 134);
            label2.Name = "label2";
            label2.Size = new Size(364, 38);
            label2.TabIndex = 6;
            label2.Text = "Manage Detained Licenses";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Detain_512;
            pictureBox1.Location = new Point(521, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1301, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnRelease);
            Controls.Add(btnDetain);
            Controls.Add(btnClose);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "frmManageDetainedLicenses";
            Text = "frmManageDetainedLicenses";
            Load += frmManageDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private Label lblRecords;
        private Button btnClose;
        private Button btnDetain;
        private Button btnRelease;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showPersonDetailesToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailesToolStripMenuItem;
        private ToolStripMenuItem showLicensesHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseToolStripMenuItem;
        private Label label2;
        private PictureBox pictureBox1;
    }
}