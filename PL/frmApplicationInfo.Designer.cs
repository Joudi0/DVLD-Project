namespace PL
{
    partial class frmApplicationInfo
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
            ctrlApplicationInfo1 = new PL.ctrlApplicationInfo();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.BackColor = Color.Gray;
            ctrlApplicationInfo1.Location = new Point(12, 26);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(724, 366);
            ctrlApplicationInfo1.TabIndex = 0;
            ctrlApplicationInfo1.Load += ctrlApplicationInfo1_Load;
            // 
            // frmApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmApplicationInfo";
            Text = "frmApplicationInfo";
            Load += frmApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private PL.ctrlApplicationInfo ctrlApplicationInfo1;
    }
}