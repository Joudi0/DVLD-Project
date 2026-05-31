namespace PL
{
    partial class frmTakeTest
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
            ctrlShowTestAppointment1 = new ctrlShowTestAppointment();
            rbFail = new RadioButton();
            rbPass = new RadioButton();
            tbNotes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            label3 = new Label();
            lblTestID = new Label();
            SuspendLayout();
            // 
            // ctrlShowTestAppointment1
            // 
            ctrlShowTestAppointment1.BackColor = Color.Gray;
            ctrlShowTestAppointment1.Location = new Point(67, -3);
            ctrlShowTestAppointment1.Name = "ctrlShowTestAppointment1";
            ctrlShowTestAppointment1.Size = new Size(594, 485);
            ctrlShowTestAppointment1.TabIndex = 0;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Location = new Point(204, 529);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(52, 24);
            rbFail.TabIndex = 1;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Location = new Point(121, 529);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(57, 24);
            rbPass.TabIndex = 2;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(121, 572);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(372, 27);
            tbNotes.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 525);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 572);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 5;
            label2.Text = "Notes";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(694, 570);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(582, 570);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 485);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 8;
            label3.Text = "Test ID:";
            // 
            // lblTestID
            // 
            lblTestID.AutoSize = true;
            lblTestID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTestID.Location = new Point(254, 485);
            lblTestID.Name = "lblTestID";
            lblTestID.Size = new Size(131, 28);
            lblTestID.TabIndex = 9;
            lblTestID.Text = "Not Taken Yet";
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 644);
            Controls.Add(lblTestID);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNotes);
            Controls.Add(rbPass);
            Controls.Add(rbFail);
            Controls.Add(ctrlShowTestAppointment1);
            Name = "frmTakeTest";
            Text = "frmTakeTest";
            Load += frmTakeTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlShowTestAppointment ctrlShowTestAppointment1;
        private RadioButton rbFail;
        private RadioButton rbPass;
        private TextBox tbNotes;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private Label lblTestID;
    }
}