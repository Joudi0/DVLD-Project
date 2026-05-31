namespace PL
{
    partial class ctrlPersonInfoFilter
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
            ctrlPersonInfo1 = new ctrlPersonInfo();
            ctrlFindPerson1 = new ctrlFindPerson();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.Gray;
            ctrlPersonInfo1.Location = new Point(3, 160);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(814, 445);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlFindPerson1
            // 
            ctrlFindPerson1.BackColor = Color.Gray;
            ctrlFindPerson1.Location = new Point(510, 21);
            ctrlFindPerson1.Name = "ctrlFindPerson1";
            ctrlFindPerson1.Size = new Size(572, 65);
            ctrlFindPerson1.TabIndex = 1;
            // 
            // ctrlPersonInfoFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(ctrlFindPerson1);
            Controls.Add(ctrlPersonInfo1);
            Name = "ctrlPersonInfoFilter";
            Size = new Size(1105, 611);
            Load += ctrlPersonInfoFilter_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlFindPerson ctrlFindPerson1;
    }
}
