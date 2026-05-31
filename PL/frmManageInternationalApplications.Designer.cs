namespace PL
{
    partial class frmManageInternationalApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalApplications));
            dgvInternational = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblRecords = new Label();
            cms = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showInternationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvInternational).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cms.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInternational
            // 
            dgvInternational.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternational.ContextMenuStrip = cms;
            dgvInternational.Location = new Point(204, 250);
            dgvInternational.Name = "dgvInternational";
            dgvInternational.RowHeadersWidth = 51;
            dgvInternational.Size = new Size(993, 188);
            dgvInternational.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(578, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 138);
            label1.Name = "label1";
            label1.Size = new Size(379, 31);
            label1.TabIndex = 2;
            label1.Text = "International License Applications";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 418);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 3;
            label2.Text = "Records: ";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(116, 418);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(30, 28);
            lblRecords.TabIndex = 4;
            lblRecords.Text = "??";
            // 
            // cms
            // 
            cms.ImageScalingSize = new Size(20, 20);
            cms.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showInternationalLicenseToolStripMenuItem });
            cms.Name = "contextMenuStrip1";
            cms.Size = new Size(224, 76);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(223, 24);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(223, 24);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showInternationalLicenseToolStripMenuItem
            // 
            showInternationalLicenseToolStripMenuItem.Name = "showInternationalLicenseToolStripMenuItem";
            showInternationalLicenseToolStripMenuItem.Size = new Size(223, 24);
            showInternationalLicenseToolStripMenuItem.Text = "Show Licenses History";
            showInternationalLicenseToolStripMenuItem.Click += showInternationalLicenseToolStripMenuItem_Click;
            // 
            // frmManageInternationalApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1350, 450);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvInternational);
            Name = "frmManageInternationalApplications";
            Text = "frmManageInternationalApplications";
            Load += frmManageInternationalApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInternational).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cms.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInternational;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblRecords;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showInternationalLicenseToolStripMenuItem;
    }
}