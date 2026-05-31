namespace PL
{
    partial class frmFindPerson
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
            ctrlPersonInfoFilter1 = new ctrlPersonInfoFilter();
            SuspendLayout();
            // 
            // ctrlPersonInfoFilter1
            // 
            ctrlPersonInfoFilter1.BackColor = Color.Gray;
            ctrlPersonInfoFilter1.Location = new Point(0, -5);
            ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            ctrlPersonInfoFilter1.Size = new Size(938, 612);
            ctrlPersonInfoFilter1.TabIndex = 0;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1228, 610);
            Controls.Add(ctrlPersonInfoFilter1);
            Name = "frmFindPerson";
            Text = "frmFindPerson";
            Load += frmFindPerson_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
    }
}