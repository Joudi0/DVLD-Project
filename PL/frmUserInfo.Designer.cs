namespace PL
{
    partial class frmUserInfo
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
            ctrlUserInfo1 = new ctrlUserInfo();
            lbl = new Label();
            SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.BackColor = Color.Gray;
            ctrlUserInfo1.Location = new Point(5, 36);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(821, 453);
            ctrlUserInfo1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(296, 5);
            lbl.Name = "lbl";
            lbl.Size = new Size(242, 38);
            lbl.TabIndex = 1;
            lbl.Text = "User Information";
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(824, 487);
            Controls.Add(lbl);
            Controls.Add(ctrlUserInfo1);
            Name = "frmUserInfo";
            Text = "frmUserInfo";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private Label lbl;
    }
}