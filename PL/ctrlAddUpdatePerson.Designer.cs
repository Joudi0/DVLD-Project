namespace PL
{
    partial class ctrlAddUpdatePerson
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel = new Panel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pbImage = new PictureBox();
            label12 = new Label();
            tbLastName = new TextBox();
            label11 = new Label();
            tbThirdName = new TextBox();
            label10 = new Label();
            tbSecondName = new TextBox();
            label1 = new Label();
            cbNationality = new ComboBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            dtp = new DateTimePicker();
            tbAddress = new TextBox();
            tbNN = new TextBox();
            tbFirstName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            label = new Label();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 184);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 28;
            label7.Text = "Nationality:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 139);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 27;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 98);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 26;
            label9.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 227);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 25;
            label6.Text = "Addess:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 182);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 24;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 23;
            label4.Text = "Date Of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 42);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 22;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 21;
            label2.Text = "National Number:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pbImage);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbThirdName);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(tbSecondName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbNationality);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(dtp);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(tbNN);
            panel1.Controls.Add(tbFirstName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(28, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 309);
            panel1.TabIndex = 30;
            // 
            // panel
            // 
            panel.Controls.Add(rbMale);
            panel.Controls.Add(rbFemale);
            panel.Location = new Point(132, 181);
            panel.Name = "panel";
            panel.Size = new Size(158, 34);
            panel.TabIndex = 31;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(3, 7);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 45;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(77, 7);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 46;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(537, 274);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 51;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(601, 195);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(63, 20);
            linkLabel2.TabIndex = 49;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Remove";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(601, 162);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Set Image";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(601, 77);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(125, 82);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 47;
            pbImage.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(611, 9);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 44;
            label12.Text = "Last";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(601, 42);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(125, 27);
            tbLastName.TabIndex = 43;
            tbLastName.Tag = "Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(495, 9);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 42;
            label11.Text = "Thrid";
            // 
            // tbThirdName
            // 
            tbThirdName.Location = new Point(453, 42);
            tbThirdName.Name = "tbThirdName";
            tbThirdName.Size = new Size(125, 27);
            tbThirdName.TabIndex = 41;
            tbThirdName.Tag = "Third Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(332, 9);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 40;
            label10.Text = "Second";
            // 
            // tbSecondName
            // 
            tbSecondName.Location = new Point(300, 42);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(125, 27);
            tbSecondName.TabIndex = 39;
            tbSecondName.Tag = "Second Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 38;
            label1.Text = "First";
            // 
            // cbNationality
            // 
            cbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNationality.FormattingEnabled = true;
            cbNationality.Items.AddRange(new object[] { "Male", "Female" });
            cbNationality.Location = new Point(410, 176);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(151, 28);
            cbNationality.TabIndex = 37;
            cbNationality.Tag = "Nationality";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(410, 132);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(151, 27);
            tbEmail.TabIndex = 36;
            tbEmail.Tag = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(410, 91);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(151, 27);
            tbPhone.TabIndex = 35;
            tbPhone.Tag = "Phone";
            // 
            // dtp
            // 
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(145, 144);
            dtp.MaxDate = new DateTime(2008, 3, 1, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(125, 27);
            dtp.TabIndex = 34;
            dtp.Tag = "Date of Birth";
            dtp.Value = new DateTime(2008, 3, 1, 0, 0, 0, 0);
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(132, 224);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(567, 27);
            tbAddress.TabIndex = 32;
            tbAddress.Tag = "Address";
            // 
            // tbNN
            // 
            tbNN.Location = new Point(145, 91);
            tbNN.Name = "tbNN";
            tbNN.Size = new Size(125, 27);
            tbNN.TabIndex = 31;
            tbNN.Tag = "National Number";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(145, 42);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(125, 27);
            tbFirstName.TabIndex = 30;
            tbFirstName.Tag = "First Name";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(264, 11);
            label.Name = "label";
            label.Size = new Size(234, 38);
            label.TabIndex = 31;
            label.Text = "Add New Person";
            // 
            // ctrlAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(label);
            Controls.Add(panel1);
            Name = "ctrlAddUpdate";
            Size = new Size(808, 361);
            Load += ctrlAddUpdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DateTimePicker dtp;
        private TextBox tbAddress;
        private TextBox tbNN;
        private TextBox tbFirstName;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label12;
        private TextBox tbLastName;
        private Label label11;
        private TextBox tbThirdName;
        private Label label10;
        private TextBox tbSecondName;
        private Label label1;
        private ComboBox cbNationality;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private PictureBox pbImage;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel;
        private OpenFileDialog openFileDialog1;
        private Label label;
    }
}
