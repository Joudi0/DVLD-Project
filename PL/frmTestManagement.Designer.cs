namespace PL
{
    partial class frmTestManagement
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
            lblRecords = new Label();
            button1 = new Button();
            btnAdd = new Button();
            dgv = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            pbTestImage = new PictureBox();
            lblTitle = new Label();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            ctrlLocalLincenseApplication1 = new ctrlLocalLincenseApplication();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTestImage).BeginInit();
            SuspendLayout();
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(37, 734);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(118, 28);
            lblRecords.TabIndex = 21;
            lblRecords.Text = "# Recoreds: ";
            // 
            // button1
            // 
            button1.Location = new Point(923, 737);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1042, 734);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = contextMenuStrip1;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new Point(4, 541);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1132, 190);
            dgv.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(210, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(210, 24);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // pbTestImage
            // 
            pbTestImage.Location = new Point(487, -3);
            pbTestImage.Name = "pbTestImage";
            pbTestImage.Size = new Size(169, 140);
            pbTestImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestImage.TabIndex = 22;
            pbTestImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(662, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 28);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "??";
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.BackColor = Color.Gray;
            ctrlApplicationInfo1.Location = new Point(191, 259);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(709, 276);
            ctrlApplicationInfo1.TabIndex = 24;
            // 
            // ctrlLocalLincenseApplication1
            // 
            ctrlLocalLincenseApplication1.BackColor = Color.Gray;
            ctrlLocalLincenseApplication1.Location = new Point(182, 113);
            ctrlLocalLincenseApplication1.Name = "ctrlLocalLincenseApplication1";
            ctrlLocalLincenseApplication1.Size = new Size(718, 147);
            ctrlLocalLincenseApplication1.TabIndex = 25;
            // 
            // frmTestManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1142, 769);
            Controls.Add(ctrlLocalLincenseApplication1);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbTestImage);
            Controls.Add(lblRecords);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Name = "frmTestManagement";
            Text = "frmTestAppointmentManagement";
            Load += frmVisionTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTestImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecords;
        private Button button1;
        private Button btnAdd;
        private DataGridView dgv;
        private PictureBox pbTestImage;
        private Label lblTitle;
        private PL.ctrlApplicationInfo ctrlApplicationInfo1;
        private PL.ctrlLocalLincenseApplication ctrlLocalLincenseApplication1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}