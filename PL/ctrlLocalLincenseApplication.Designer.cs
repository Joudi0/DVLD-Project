namespace PL
{
    partial class ctrlLocalLincenseApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            linklblLicense = new LinkLabel();
            lblExams = new Label();
            lblLicenseClass = new Label();
            lblID = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "L.L.A.ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(371, 14);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 1;
            label2.Text = "License Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 70);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 2;
            label3.Text = "Exams Passed:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linklblLicense);
            groupBox1.Controls.Add(lblExams);
            groupBox1.Controls.Add(lblLicenseClass);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local Driving License Application";
            // 
            // linklblLicense
            // 
            linklblLicense.AutoSize = true;
            linklblLicense.Location = new Point(371, 78);
            linklblLicense.Name = "linklblLicense";
            linklblLicense.Size = new Size(127, 20);
            linklblLicense.TabIndex = 6;
            linklblLicense.TabStop = true;
            linklblLicense.Text = "Show License Info";
            // 
            // lblExams
            // 
            lblExams.AutoSize = true;
            lblExams.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExams.Location = new Point(167, 70);
            lblExams.Name = "lblExams";
            lblExams.Size = new Size(30, 28);
            lblExams.TabIndex = 5;
            lblExams.Text = "??";
            // 
            // lblLicenseClass
            // 
            lblLicenseClass.AutoSize = true;
            lblLicenseClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseClass.Location = new Point(530, 14);
            lblLicenseClass.Name = "lblLicenseClass";
            lblLicenseClass.Size = new Size(30, 28);
            lblLicenseClass.TabIndex = 4;
            lblLicenseClass.Text = "??";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(103, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 28);
            lblID.TabIndex = 3;
            lblID.Text = "??";
            // 
            // ctrlLocalLincenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(groupBox1);
            Name = "ctrlLocalLincenseApplication";
            Size = new Size(825, 142);
            Load += ctrlLocalLincenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label lblExams;
        private Label lblLicenseClass;
        private Label lblID;
        private LinkLabel linklblLicense;
    }
}
