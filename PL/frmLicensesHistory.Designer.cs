namespace PL
{
    partial class frmLicensesHistory
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
            ctrlPersonInfo1 = new ctrlPersonInfo();
            ctrlLicenseHistory1 = new ctrlLicenseHistory();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.Gray;
            ctrlPersonInfo1.Location = new Point(2, -1);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(910, 449);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlLicenseHistory1
            // 
            ctrlLicenseHistory1.BackColor = Color.Gray;
            ctrlLicenseHistory1.Location = new Point(2, 454);
            ctrlLicenseHistory1.Name = "ctrlLicenseHistory1";
            ctrlLicenseHistory1.Size = new Size(1278, 286);
            ctrlLicenseHistory1.TabIndex = 1;
            // 
            // frmLicensesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1323, 745);
            Controls.Add(ctrlLicenseHistory1);
            Controls.Add(ctrlPersonInfo1);
            Name = "frmLicensesHistory";
            Text = "frmLicensesHistory";
            Load += frmLicensesHistory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlLicenseHistory ctrlLicenseHistory1;
    }
}