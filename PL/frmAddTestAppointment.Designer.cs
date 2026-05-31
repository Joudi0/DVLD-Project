namespace PL
{
    partial class frmAddTestAppointment
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ctrlShowTestAppointment1 = new ctrlShowTestAppointment();
            btnSave = new Button();
            btnCancel = new Button();
            ctrlRetakeTestInfo1 = new ctrlRetakeTestInfo();
            SuspendLayout();
            // 
            // ctrlShowTestAppointment1
            // 
            ctrlShowTestAppointment1.BackColor = Color.Gray;
            ctrlShowTestAppointment1.Location = new Point(66, -1);
            ctrlShowTestAppointment1.Name = "ctrlShowTestAppointment1";
            ctrlShowTestAppointment1.Size = new Size(661, 451);
            ctrlShowTestAppointment1.TabIndex = 0;
            ctrlShowTestAppointment1.Load += ctrlShowTestAppointment1_Load;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(662, 531);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(548, 531);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ctrlRetakeTestInfo1
            // 
            ctrlRetakeTestInfo1.BackColor = Color.Gray;
            ctrlRetakeTestInfo1.Location = new Point(66, 480);
            ctrlRetakeTestInfo1.Name = "ctrlRetakeTestInfo1";
            ctrlRetakeTestInfo1.Size = new Size(254, 87);
            ctrlRetakeTestInfo1.TabIndex = 3;
            // 
            // frmAddTestAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 604);
            Controls.Add(ctrlRetakeTestInfo1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(ctrlShowTestAppointment1);
            Name = "frmAddTestAppointment";
            Text = "frmAddTestAppointment";
            Load += frmAddTestAppointment_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ctrlShowTestAppointment ctrlShowTestAppointment1;
        private Button btnSave;
        private Button btnCancel;
        private ctrlRetakeTestInfo ctrlRetakeTestInfo1;
    }
}