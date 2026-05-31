namespace PL
{
    partial class frmReplacementLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementLicense));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnReplace = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            ctrlFindLicense1 = new ctrlFindLicense();
            rbDamaged = new RadioButton();
            rbLost = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(936, 481);
            label4.Name = "label4";
            label4.Size = new Size(34, 31);
            label4.TabIndex = 15;
            label4.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(754, 481);
            label3.Name = "label3";
            label3.Size = new Size(188, 31);
            label3.TabIndex = 14;
            label3.Text = "New License ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(754, 643);
            label2.Name = "label2";
            label2.Size = new Size(579, 31);
            label2.TabIndex = 13;
            label2.Text = "In Addition of Application fees, New license cost 20$";
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(997, 483);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(94, 29);
            btnReplace.TabIndex = 12;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1229, 13);
            label1.Name = "label1";
            label1.Size = new Size(236, 31);
            label1.TabIndex = 10;
            label1.Text = "Replacement License";
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.BackColor = Color.Gray;
            ctrlApplicationInfo1.Location = new Point(39, 455);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(709, 279);
            ctrlApplicationInfo1.TabIndex = 9;
            // 
            // ctrlFindLicense1
            // 
            ctrlFindLicense1.BackColor = Color.Gray;
            ctrlFindLicense1.Location = new Point(30, 16);
            ctrlFindLicense1.Name = "ctrlFindLicense1";
            ctrlFindLicense1.Size = new Size(1149, 433);
            ctrlFindLicense1.TabIndex = 8;
            // 
            // rbDamaged
            // 
            rbDamaged.AutoSize = true;
            rbDamaged.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbDamaged.Location = new Point(1229, 61);
            rbDamaged.Name = "rbDamaged";
            rbDamaged.Size = new Size(129, 32);
            rbDamaged.TabIndex = 16;
            rbDamaged.TabStop = true;
            rbDamaged.Text = "Damaged ";
            rbDamaged.UseVisualStyleBackColor = true;
            // 
            // rbLost
            // 
            rbLost.AutoSize = true;
            rbLost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLost.Location = new Point(1386, 61);
            rbLost.Name = "rbLost";
            rbLost.Size = new Size(72, 32);
            rbLost.TabIndex = 17;
            rbLost.TabStop = true;
            rbLost.Text = "Lost";
            rbLost.UseVisualStyleBackColor = true;
            // 
            // frmReplacementLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1513, 746);
            Controls.Add(rbLost);
            Controls.Add(rbDamaged);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnReplace);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(ctrlFindLicense1);
            Name = "frmReplacementLicense";
            Text = "frmReplacementLicense";
            Load += frmReplacementLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnReplace;
        private PictureBox pictureBox1;
        private Label label1;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private ctrlFindLicense ctrlFindLicense1;
        private RadioButton rbDamaged;
        private RadioButton rbLost;
    }
}