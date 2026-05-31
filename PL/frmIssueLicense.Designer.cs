namespace PL
{
    partial class frmIssueLicense
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
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            ctrlLocalLincenseApplication1 = new ctrlLocalLincenseApplication();
            tbNotes = new TextBox();
            label1 = new Label();
            btnIssue = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.BackColor = Color.Gray;
            ctrlApplicationInfo1.Location = new Point(184, 149);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(711, 277);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // ctrlLocalLincenseApplication1
            // 
            ctrlLocalLincenseApplication1.BackColor = Color.Gray;
            ctrlLocalLincenseApplication1.Location = new Point(171, -4);
            ctrlLocalLincenseApplication1.Name = "ctrlLocalLincenseApplication1";
            ctrlLocalLincenseApplication1.Size = new Size(816, 147);
            ctrlLocalLincenseApplication1.TabIndex = 1;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(1013, 160);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(402, 27);
            tbNotes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(923, 163);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Notes:";
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(1287, 367);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 4;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1164, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmIssueLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1427, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnIssue);
            Controls.Add(label1);
            Controls.Add(tbNotes);
            Controls.Add(ctrlLocalLincenseApplication1);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmIssueLicense";
            Text = "frmIssueLicense";
            Load += frmIssueLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlApplicationInfo ctrlApplicationInfo1;
        private ctrlLocalLincenseApplication ctrlLocalLincenseApplication1;
        private TextBox tbNotes;
        private Label label1;
        private Button btnIssue;
        private Button btnCancel;
    }
}