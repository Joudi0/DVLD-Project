namespace PL
{
    partial class frmShowInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicense));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ctrlInternationalApplicationInfo1 = new ctrlInternationalApplicationInfo();
            ctrlShowLicense1 = new ctrlShowLicense();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(605, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 218);
            label1.Name = "label1";
            label1.Size = new Size(360, 31);
            label1.TabIndex = 1;
            label1.Text = "Driver International License Info";
            // 
            // ctrlInternationalApplicationInfo1
            // 
            ctrlInternationalApplicationInfo1.BackColor = Color.Gray;
            ctrlInternationalApplicationInfo1.Location = new Point(12, 252);
            ctrlInternationalApplicationInfo1.Name = "ctrlInternationalApplicationInfo1";
            ctrlInternationalApplicationInfo1.Size = new Size(731, 46);
            ctrlInternationalApplicationInfo1.TabIndex = 2;
            // 
            // ctrlShowLicense1
            // 
            ctrlShowLicense1.BackColor = Color.Gray;
            ctrlShowLicense1.Location = new Point(12, 295);
            ctrlShowLicense1.Name = "ctrlShowLicense1";
            ctrlShowLicense1.Size = new Size(1144, 380);
            ctrlShowLicense1.TabIndex = 3;
            // 
            // frmShowInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1361, 677);
            Controls.Add(ctrlShowLicense1);
            Controls.Add(ctrlInternationalApplicationInfo1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmShowInternationalLicense";
            Text = "frmShowInternationalLicense";
            Load += frmShowInternationalLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ctrlInternationalApplicationInfo ctrlInternationalApplicationInfo1;
        private ctrlShowLicense ctrlShowLicense1;
    }
}