namespace PL
{
    partial class frmAddUpdatePerson
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
            ctrlAddUpdate1 = new ctrlAddUpdatePerson();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlAddUpdate1
            // 
            ctrlAddUpdate1.BackColor = Color.Gray;
            ctrlAddUpdate1.Location = new Point(42, 32);
            ctrlAddUpdate1.Name = "ctrlAddUpdate1";
            ctrlAddUpdate1.Size = new Size(801, 358);
            ctrlAddUpdate1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.ManagePeople;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(841, 450);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlAddUpdate1);
            Name = "frmAddUpdate";
            Text = "frmAddUpdate";
            Load += frmAddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlAddUpdatePerson ctrlAddUpdate1;
        private PictureBox pictureBox1;
    }
}