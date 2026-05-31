namespace PL
{
    partial class ctrlLicenseHistory
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
            tabPage1 = new TabPage();
            lblLocalRecords = new Label();
            dgvLocal = new DataGridView();
            tabPage2 = new TabPage();
            dgvInternational = new DataGridView();
            lblInternationalRecords = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternational).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(41, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1231, 280);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(lblLocalRecords);
            tabPage1.Controls.Add(dgvLocal);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1223, 247);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            // 
            // lblLocalRecords
            // 
            lblLocalRecords.AutoSize = true;
            lblLocalRecords.Location = new Point(6, 224);
            lblLocalRecords.Name = "lblLocalRecords";
            lblLocalRecords.Size = new Size(82, 20);
            lblLocalRecords.TabIndex = 1;
            lblLocalRecords.Text = "# Records: ";
            // 
            // dgvLocal
            // 
            dgvLocal.BackgroundColor = Color.Gray;
            dgvLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocal.Location = new Point(-4, 0);
            dgvLocal.Name = "dgvLocal";
            dgvLocal.ReadOnly = true;
            dgvLocal.RowHeadersWidth = 51;
            dgvLocal.Size = new Size(1223, 221);
            dgvLocal.TabIndex = 0;
            dgvLocal.CellContentClick += dgvLocal_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(dgvInternational);
            tabPage2.Controls.Add(lblInternationalRecords);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1223, 247);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            // 
            // dgvInternational
            // 
            dgvInternational.BackgroundColor = Color.Gray;
            dgvInternational.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternational.Location = new Point(3, 0);
            dgvInternational.Name = "dgvInternational";
            dgvInternational.ReadOnly = true;
            dgvInternational.RowHeadersWidth = 51;
            dgvInternational.Size = new Size(1220, 226);
            dgvInternational.TabIndex = 3;
            // 
            // lblInternationalRecords
            // 
            lblInternationalRecords.AutoSize = true;
            lblInternationalRecords.Location = new Point(0, 224);
            lblInternationalRecords.Name = "lblInternationalRecords";
            lblInternationalRecords.Size = new Size(82, 20);
            lblInternationalRecords.TabIndex = 2;
            lblInternationalRecords.Text = "# Records: ";
            // 
            // ctrlLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(tabControl1);
            Name = "ctrlLicenseHistory";
            Size = new Size(1274, 280);
            Load += ctrlLicenseHistory_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternational).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvLocal;
        private Label lblLocalRecords;
        private DataGridView dgvInternational;
        private Label lblInternationalRecords;
    }
}
