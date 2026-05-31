namespace PL
{
    partial class ctrlApplicationInfo
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
            gpInfo = new GroupBox();
            linklblPersonInfo = new LinkLabel();
            dtpDate = new DateTimePicker();
            dtpStatus = new DateTimePicker();
            lblUsername = new Label();
            lblFullName = new Label();
            lblFees = new Label();
            lblType = new Label();
            lblStatus = new Label();
            lblID = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gpInfo
            // 
            gpInfo.Controls.Add(linklblPersonInfo);
            gpInfo.Controls.Add(dtpDate);
            gpInfo.Controls.Add(dtpStatus);
            gpInfo.Controls.Add(lblUsername);
            gpInfo.Controls.Add(lblFullName);
            gpInfo.Controls.Add(lblFees);
            gpInfo.Controls.Add(lblType);
            gpInfo.Controls.Add(lblStatus);
            gpInfo.Controls.Add(lblID);
            gpInfo.Controls.Add(label8);
            gpInfo.Controls.Add(label7);
            gpInfo.Controls.Add(label6);
            gpInfo.Controls.Add(label5);
            gpInfo.Controls.Add(label4);
            gpInfo.Controls.Add(label3);
            gpInfo.Controls.Add(label2);
            gpInfo.Controls.Add(label1);
            gpInfo.Location = new Point(0, 3);
            gpInfo.Name = "gpInfo";
            gpInfo.Size = new Size(705, 271);
            gpInfo.TabIndex = 0;
            gpInfo.TabStop = false;
            gpInfo.Text = "Basic Application Info";
            gpInfo.Enter += gpInfo_Enter;
            // 
            // linklblPersonInfo
            // 
            linklblPersonInfo.AutoSize = true;
            linklblPersonInfo.Location = new Point(6, 239);
            linklblPersonInfo.Name = "linklblPersonInfo";
            linklblPersonInfo.Size = new Size(118, 20);
            linklblPersonInfo.TabIndex = 16;
            linklblPersonInfo.TabStop = true;
            linklblPersonInfo.Text = "View Person Info";
            linklblPersonInfo.LinkClicked += linklblPersonInfo_LinkClicked;
            // 
            // dtpDate
            // 
            dtpDate.Enabled = false;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(581, 87);
            dtpDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(124, 27);
            dtpDate.TabIndex = 15;
            // 
            // dtpStatus
            // 
            dtpStatus.Enabled = false;
            dtpStatus.Format = DateTimePickerFormat.Short;
            dtpStatus.Location = new Point(575, 138);
            dtpStatus.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtpStatus.Name = "dtpStatus";
            dtpStatus.Size = new Size(124, 27);
            dtpStatus.TabIndex = 14;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(570, 190);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 28);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "??";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(174, 190);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(30, 28);
            lblFullName.TabIndex = 12;
            lblFullName.Text = "??";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(174, 136);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(30, 28);
            lblFees.TabIndex = 11;
            lblFees.Text = "??";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(174, 84);
            lblType.Name = "lblType";
            lblType.Size = new Size(30, 28);
            lblType.TabIndex = 10;
            lblType.Text = "??";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(575, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(30, 28);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "??";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(174, 41);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 28);
            lblID.TabIndex = 8;
            lblID.Text = "??";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(454, 190);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 7;
            label8.Text = "Created By:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(454, 136);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 6;
            label7.Text = "Status Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(507, 84);
            label6.Name = "label6";
            label6.Size = new Size(57, 28);
            label6.TabIndex = 5;
            label6.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(454, 41);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "Fees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 190);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 2;
            label3.Text = "Applicatnt:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Application ID:";
            // 
            // ctrlApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(gpInfo);
            Name = "ctrlApplicationInfo";
            Size = new Size(708, 271);
            Load += ctrlApplicationInfo_Load;
            gpInfo.ResumeLayout(false);
            gpInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label lblUsername;
        private Label lblFullName;
        private Label lblFees;
        private Label lblType;
        private Label lblStatus;
        private Label lblID;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStatus;
        private LinkLabel linklblPersonInfo;
    }
}
