namespace PL
{
    partial class frmManageLocalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalLicenseApplications));
            cbStatus = new ComboBox();
            tbFilter = new TextBox();
            cb = new ComboBox();
            lblRecords = new Label();
            button1 = new Button();
            btnAdd = new Button();
            dgv = new DataGridView();
            cms = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            sheudleToolStripMenuItem = new ToolStripMenuItem();
            visionTestToolStripMenuItem = new ToolStripMenuItem();
            writtinTestToolStripMenuItem = new ToolStripMenuItem();
            streetTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "New", "Canceled", "Completed" });
            cbStatus.Location = new Point(305, 242);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(94, 28);
            cbStatus.TabIndex = 15;
            cbStatus.Visible = false;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(305, 244);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(125, 27);
            tbFilter.TabIndex = 14;
            tbFilter.Visible = false;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // cb
            // 
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Location = new Point(87, 242);
            cb.Name = "cb";
            cb.Size = new Size(191, 28);
            cb.TabIndex = 13;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(49, 563);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(118, 28);
            lblRecords.TabIndex = 12;
            lblRecords.Text = "# Recoreds: ";
            // 
            // button1
            // 
            button1.Location = new Point(1375, 554);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1375, 242);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = cms;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new Point(9, 324);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1529, 190);
            dgv.TabIndex = 8;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // cms
            // 
            cms.ImageScalingSize = new Size(20, 20);
            cms.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, cancelApplicationToolStripMenuItem, sheudleToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cms.Name = "contextMenuStrip1";
            cms.Size = new Size(293, 224);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(292, 24);
            showToolStripMenuItem.Text = "Show Application Details";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(292, 24);
            updateToolStripMenuItem.Text = "Edit Application";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(292, 24);
            deleteToolStripMenuItem.Text = "Delete Application";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(292, 24);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // sheudleToolStripMenuItem
            // 
            sheudleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visionTestToolStripMenuItem, writtinTestToolStripMenuItem, streetTestToolStripMenuItem });
            sheudleToolStripMenuItem.Name = "sheudleToolStripMenuItem";
            sheudleToolStripMenuItem.Size = new Size(292, 24);
            sheudleToolStripMenuItem.Text = "Sechdule Test";
            // 
            // visionTestToolStripMenuItem
            // 
            visionTestToolStripMenuItem.Image = (Image)resources.GetObject("visionTestToolStripMenuItem.Image");
            visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            visionTestToolStripMenuItem.Size = new Size(224, 26);
            visionTestToolStripMenuItem.Text = "Vision Test";
            visionTestToolStripMenuItem.Click += visionTestToolStripMenuItem_Click;
            // 
            // writtinTestToolStripMenuItem
            // 
            writtinTestToolStripMenuItem.Image = (Image)resources.GetObject("writtinTestToolStripMenuItem.Image");
            writtinTestToolStripMenuItem.Name = "writtinTestToolStripMenuItem";
            writtinTestToolStripMenuItem.Size = new Size(224, 26);
            writtinTestToolStripMenuItem.Text = "Writtin Test";
            writtinTestToolStripMenuItem.Click += writtinTestToolStripMenuItem_Click;
            // 
            // streetTestToolStripMenuItem
            // 
            streetTestToolStripMenuItem.Image = (Image)resources.GetObject("streetTestToolStripMenuItem.Image");
            streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            streetTestToolStripMenuItem.Size = new Size(224, 26);
            streetTestToolStripMenuItem.Text = "Street Test";
            streetTestToolStripMenuItem.Click += streetTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(292, 24);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(292, 24);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(292, 24);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(620, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(798, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 9);
            label1.Name = "label1";
            label1.Size = new Size(461, 28);
            label1.TabIndex = 19;
            label1.Text = "Local Driving Licenses Applicaton Management";
            // 
            // frmManageLocalLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1547, 717);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbStatus);
            Controls.Add(tbFilter);
            Controls.Add(cb);
            Controls.Add(lblRecords);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Name = "frmManageLocalLicenseApplications";
            Text = "frmManageLocalDrivingLicense";
            Load += frmManageLocalDrivingLicense_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private TextBox tbFilter;
        private ComboBox cb;
        private Label lblRecords;
        private Button button1;
        private Button btnAdd;
        private DataGridView dgv;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem sheudleToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem visionTestToolStripMenuItem;
        private ToolStripMenuItem writtinTestToolStripMenuItem;
        private ToolStripMenuItem streetTestToolStripMenuItem;
        private Label label1;
    }
}