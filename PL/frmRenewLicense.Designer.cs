namespace PL
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            ctrlFindLicense1 = new ctrlFindLicense();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRenew = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlFindLicense1
            // 
            ctrlFindLicense1.BackColor = Color.Gray;
            ctrlFindLicense1.Location = new Point(3, 12);
            ctrlFindLicense1.Name = "ctrlFindLicense1";
            ctrlFindLicense1.Size = new Size(1149, 433);
            ctrlFindLicense1.TabIndex = 0;
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.BackColor = Color.Gray;
            ctrlApplicationInfo1.Location = new Point(12, 451);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(709, 279);
            ctrlApplicationInfo1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1202, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 31);
            label1.TabIndex = 2;
            label1.Text = "Renew Driving License";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(431, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnRenew
            // 
            btnRenew.Location = new Point(970, 479);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(94, 29);
            btnRenew.TabIndex = 4;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(727, 639);
            label2.Name = "label2";
            label2.Size = new Size(520, 31);
            label2.TabIndex = 5;
            label2.Text = "Application Fees is 7$ and New license cost 20$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(727, 477);
            label3.Name = "label3";
            label3.Size = new Size(188, 31);
            label3.TabIndex = 6;
            label3.Text = "New License ID: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(909, 477);
            label4.Name = "label4";
            label4.Size = new Size(34, 31);
            label4.TabIndex = 7;
            label4.Text = "??";
            // 
            // frmRenewLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1499, 726);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRenew);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(ctrlFindLicense1);
            Name = "frmRenewLicense";
            Text = "frmRenewLicense";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlFindLicense ctrlFindLicense1;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnRenew;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}