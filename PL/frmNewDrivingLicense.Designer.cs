namespace PL
{
    partial class frmNewDrivingLicense
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
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tpPerson = new TabPage();
            btnAddPerson = new Button();
            ctrlPersonInfoFilter1 = new ctrlPersonInfoFilter();
            tpApp = new TabPage();
            cbClasses = new ComboBox();
            dtp = new DateTimePicker();
            lblUsername = new Label();
            lblFees = new Label();
            label6 = new Label();
            label1 = new Label();
            lblID = new Label();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNext = new Button();
            btnClose1 = new Button();
            tabControl1.SuspendLayout();
            tpPerson.SuspendLayout();
            tpApp.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(530, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPerson);
            tabControl1.Controls.Add(tpApp);
            tabControl1.Location = new Point(168, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 724);
            tabControl1.TabIndex = 3;
            // 
            // tpPerson
            // 
            tpPerson.BackColor = Color.Gray;
            tpPerson.Controls.Add(btnAddPerson);
            tpPerson.Controls.Add(ctrlPersonInfoFilter1);
            tpPerson.Location = new Point(4, 29);
            tpPerson.Name = "tpPerson";
            tpPerson.Padding = new Padding(3);
            tpPerson.Size = new Size(1063, 691);
            tpPerson.TabIndex = 0;
            tpPerson.Text = "Person Info";
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(969, 93);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(94, 29);
            btnAddPerson.TabIndex = 1;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // ctrlPersonInfoFilter1
            // 
            ctrlPersonInfoFilter1.BackColor = Color.Gray;
            ctrlPersonInfoFilter1.Location = new Point(-7, 62);
            ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            ctrlPersonInfoFilter1.Size = new Size(985, 611);
            ctrlPersonInfoFilter1.TabIndex = 0;
            // 
            // tpApp
            // 
            tpApp.BackColor = Color.Gray;
            tpApp.Controls.Add(cbClasses);
            tpApp.Controls.Add(dtp);
            tpApp.Controls.Add(lblUsername);
            tpApp.Controls.Add(lblFees);
            tpApp.Controls.Add(label6);
            tpApp.Controls.Add(label1);
            tpApp.Controls.Add(lblID);
            tpApp.Controls.Add(btnSave);
            tpApp.Controls.Add(label4);
            tpApp.Controls.Add(label3);
            tpApp.Controls.Add(label2);
            tpApp.Location = new Point(4, 29);
            tpApp.Name = "tpApp";
            tpApp.Padding = new Padding(3);
            tpApp.Size = new Size(1063, 691);
            tpApp.TabIndex = 1;
            tpApp.Text = "Application Info";
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(544, 167);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(235, 28);
            cbClasses.TabIndex = 25;
            // 
            // dtp
            // 
            dtp.Enabled = false;
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(546, 117);
            dtp.MinDate = new DateTime(2026, 2, 21, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(114, 27);
            dtp.TabIndex = 23;
            dtp.Value = new DateTime(2026, 2, 21, 0, 0, 0, 0);
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Georgia", 12F);
            lblUsername.Location = new Point(544, 275);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 24);
            lblUsername.TabIndex = 22;
            lblUsername.Text = "??";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Georgia", 12F);
            lblFees.Location = new Point(546, 228);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(30, 24);
            lblFees.TabIndex = 21;
            lblFees.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(331, 271);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 20;
            label6.Text = "Created By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 221);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 19;
            label1.Text = "Application Fees:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Georgia", 12F);
            lblID.Location = new Point(544, 68);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 24);
            lblID.TabIndex = 17;
            lblID.Text = "??";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(898, 598);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 49);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 167);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 12;
            label4.Text = "License Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 117);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 11;
            label3.Text = "Application Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 68);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 10;
            label2.Text = "Application ID:";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1258, 589);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnClose1
            // 
            btnClose1.Location = new Point(1258, 646);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(94, 29);
            btnClose1.TabIndex = 3;
            btnClose1.Text = "Close";
            btnClose1.UseVisualStyleBackColor = true;
            btnClose1.Click += btnClose1_Click;
            // 
            // frmNewDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1375, 717);
            Controls.Add(btnClose1);
            Controls.Add(lblTitle);
            Controls.Add(btnNext);
            Controls.Add(tabControl1);
            Name = "frmNewDrivingLicense";
            Text = "frmNewDrivingLicense";
            Load += frmNewDrivingLicense_Load;
            tabControl1.ResumeLayout(false);
            tpPerson.ResumeLayout(false);
            tpApp.ResumeLayout(false);
            tpApp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tpPerson;
        private Button btnAddPerson;
        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
        private TabPage tpApp;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNext;
        private Label lblUsername;
        private Label lblFees;
        private Label label6;
        private Label label1;
        private Label lblID;
        private DateTimePicker dtp;
        private ComboBox cbClasses;
        private Button btnClose1;
    }
}