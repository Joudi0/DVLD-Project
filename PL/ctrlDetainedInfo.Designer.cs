namespace PL
{
    partial class ctrlDetainedInfo
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
            groupBox1 = new GroupBox();
            lblUsername = new Label();
            lblLicenseID = new Label();
            label5 = new Label();
            dtp = new DateTimePicker();
            tbFees = new TextBox();
            lblDetainID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblLicenseID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtp);
            groupBox1.Controls.Add(tbFees);
            groupBox1.Controls.Add(lblDetainID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detain Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(471, 93);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 28);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "??";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(463, 38);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(30, 28);
            lblLicenseID.TabIndex = 8;
            lblLicenseID.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(355, 93);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 7;
            label5.Text = "Created By:";
            // 
            // dtp
            // 
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(140, 81);
            dtp.Name = "dtp";
            dtp.Size = new Size(125, 27);
            dtp.TabIndex = 6;
            // 
            // tbFees
            // 
            tbFees.Location = new Point(140, 129);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(125, 27);
            tbFees.TabIndex = 5;
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(109, 38);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(30, 28);
            lblDetainID.TabIndex = 4;
            lblDetainID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 3;
            label4.Text = "Detain Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "Fine Fees: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 38);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "License ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Detain ID:";
            // 
            // ctrlDetainedInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(groupBox1);
            Name = "ctrlDetainedInfo";
            Size = new Size(595, 178);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDetainID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtp;
        private TextBox tbFees;
        private Label lblUsername;
        private Label lblLicenseID;
        private Label label5;
    }
}
