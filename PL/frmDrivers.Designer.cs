namespace PL
{
    partial class frmDrivers
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
            dgvDrivers = new DataGridView();
            lblRecords = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ctrlFindPerson1 = new ctrlFindPerson();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDrivers
            // 
            dgvDrivers.BackgroundColor = Color.Gray;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(7, 338);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.Size = new Size(1280, 222);
            dgvDrivers.TabIndex = 0;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(12, 563);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(82, 20);
            lblRecords.TabIndex = 1;
            lblRecords.Text = "# Records: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(585, 294);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 2;
            label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Driver_Main;
            pictureBox1.Location = new Point(450, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ctrlFindPerson1
            // 
            ctrlFindPerson1.BackColor = Color.Gray;
            ctrlFindPerson1.Location = new Point(7, 267);
            ctrlFindPerson1.Name = "ctrlFindPerson1";
            ctrlFindPerson1.Size = new Size(572, 65);
            ctrlFindPerson1.TabIndex = 4;
            // 
            // frmDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1299, 592);
            Controls.Add(ctrlFindPerson1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblRecords);
            Controls.Add(dgvDrivers);
            Name = "frmDrivers";
            Text = "frmDrivers";
            Load += frmDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrivers;
        private Label lblRecords;
        private Label label1;
        private PictureBox pictureBox1;
        private ctrlFindPerson ctrlFindPerson1;
    }
}