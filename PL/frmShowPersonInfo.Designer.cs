namespace PL
{
    partial class frmShowPersonInfo
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
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.Gray;
            ctrlPersonInfo1.Location = new Point(-2, -1);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(824, 459);
            ctrlPersonInfo1.TabIndex = 0;
            ctrlPersonInfo1.Load += ctrlPersonInfo1_Load;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(823, 450);
            Controls.Add(ctrlPersonInfo1);
            Name = "frmShowPersonInfo";
            Text = "frmShowPersonInfo";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
    }
}