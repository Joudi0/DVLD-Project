namespace PL
{
    partial class frmAddUpdateUser
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
            ctrlAddUpdateUser1 = new ctrlAddUpdateUser();
            SuspendLayout();
            // 
            // ctrlAddUpdateUser1
            // 
            ctrlAddUpdateUser1.BackColor = Color.Gray;
            ctrlAddUpdateUser1.Location = new Point(1, -3);
            ctrlAddUpdateUser1.Name = "ctrlAddUpdateUser1";
            ctrlAddUpdateUser1.Size = new Size(1067, 881);
            ctrlAddUpdateUser1.TabIndex = 0;
            ctrlAddUpdateUser1.Load += ctrlAddUpdateUser1_Load;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1090, 705);
            Controls.Add(ctrlAddUpdateUser1);
            Name = "frmAddUpdateUser";
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlAddUpdateUser ctrlAddUpdateUser1;
    }
}