namespace PL
{
    partial class frmShowLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLicense));
            lblTitle = new Label();
            pbTestImage = new PictureBox();
            ctrlShowLicense1 = new ctrlShowLicense();
            ((System.ComponentModel.ISupportInitialize)pbTestImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(426, 140);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 28);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Driver License Info";
            // 
            // pbTestImage
            // 
            pbTestImage.Image = (Image)resources.GetObject("pbTestImage.Image");
            pbTestImage.Location = new Point(426, -6);
            pbTestImage.Name = "pbTestImage";
            pbTestImage.Size = new Size(175, 143);
            pbTestImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestImage.TabIndex = 28;
            pbTestImage.TabStop = false;
            // 
            // ctrlShowLicense1
            // 
            ctrlShowLicense1.BackColor = Color.Gray;
            ctrlShowLicense1.Location = new Point(12, 185);
            ctrlShowLicense1.Name = "ctrlShowLicense1";
            ctrlShowLicense1.Size = new Size(1145, 369);
            ctrlShowLicense1.TabIndex = 30;
            // 
            // frmShowLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1147, 607);
            Controls.Add(ctrlShowLicense1);
            Controls.Add(lblTitle);
            Controls.Add(pbTestImage);
            Name = "frmShowLicense";
            Text = "frmShowLicense";
            Load += frmShowLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pbTestImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbTestImage;
        private ctrlShowLicense ctrlShowLicense1;
    }
}