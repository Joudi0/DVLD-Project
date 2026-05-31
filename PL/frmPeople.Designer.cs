namespace PL
{
    partial class frmPeople
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
            showToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            button1 = new Button();
            lblRecords = new Label();
            cb = new ComboBox();
            tbFilter = new TextBox();
            cbNationality = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = cms;
            dgv.Location = new Point(-1, 223);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1529, 190);
            dgv.TabIndex = 0;
            // 
            // cms
            // 
            cms.ImageScalingSize = new Size(20, 20);
            cms.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            cms.Name = "contextMenuStrip1";
            cms.Size = new Size(128, 76);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(127, 24);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(127, 24);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(127, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.People400;
            pictureBox1.Location = new Point(694, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1365, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1365, 453);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(39, 462);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(118, 28);
            lblRecords.TabIndex = 4;
            lblRecords.Text = "# Recoreds: ";
            // 
            // cb
            // 
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "None", "Person ID", "First Name", "Second Name", "Third Name", "Last Name", "National Number", "Gender", "Phone", "Email", "Nationality" });
            cb.Location = new Point(98, 141);
            cb.Name = "cb";
            cb.Size = new Size(151, 28);
            cb.TabIndex = 5;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(286, 141);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(125, 27);
            tbFilter.TabIndex = 6;
            tbFilter.Visible = false;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // cbNationality
            // 
            cbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNationality.FormattingEnabled = true;
            cbNationality.Location = new Point(286, 140);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(151, 28);
            cbNationality.TabIndex = 7;
            cbNationality.Visible = false;
            cbNationality.SelectedIndexChanged += cbNationality_SelectedIndexChanged;
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1527, 507);
            Controls.Add(cbNationality);
            Controls.Add(tbFilter);
            Controls.Add(cb);
            Controls.Add(lblRecords);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(dgv);
            Name = "frmPeople";
            Text = "frmPeople";
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button button1;
        private Label lblRecords;
        private ComboBox cb;
        private TextBox tbFilter;
        private ComboBox cbNationality;
    }
}