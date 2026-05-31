namespace PL
{
    partial class ctrlShowApplicationInfo
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
            cbClasses = new ComboBox();
            dtp = new DateTimePicker();
            lblUsername = new Label();
            lblFees = new Label();
            label6 = new Label();
            label1 = new Label();
            lblID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(380, 254);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(235, 28);
            cbClasses.TabIndex = 35;
            // 
            // dtp
            // 
            dtp.Enabled = false;
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(382, 204);
            dtp.MinDate = new DateTime(2026, 2, 21, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(114, 27);
            dtp.TabIndex = 34;
            dtp.Value = new DateTime(2026, 2, 21, 0, 0, 0, 0);
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Georgia", 12F);
            lblUsername.Location = new Point(380, 362);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 24);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "??";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Georgia", 12F);
            lblFees.Location = new Point(382, 315);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(30, 24);
            lblFees.TabIndex = 32;
            lblFees.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 358);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 31;
            label6.Text = "Created By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 308);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 30;
            label1.Text = "Application Fees:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Georgia", 12F);
            lblID.Location = new Point(380, 155);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 24);
            lblID.TabIndex = 29;
            lblID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(167, 254);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 28;
            label4.Text = "License Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(167, 204);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 27;
            label3.Text = "Application Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 155);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 26;
            label2.Text = "Application ID:";
            // 
            // ctrlShowApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(cbClasses);
            Controls.Add(dtp);
            Controls.Add(lblUsername);
            Controls.Add(lblFees);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ctrlShowApplicationInfo";
            Size = new Size(783, 540);
            Load += ctrlShowApplicationInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbClasses;
        private DateTimePicker dtp;
        private Label lblUsername;
        private Label lblFees;
        private Label label6;
        private Label label1;
        private Label lblID;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
