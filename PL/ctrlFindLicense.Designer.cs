namespace PL
{
    partial class ctrlFindLicense
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
            tbSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            ctrlShowLicense1 = new ctrlShowLicense();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(187, 6);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(125, 27);
            tbSearch.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 6;
            label1.Text = "License ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(331, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ctrlShowLicense1
            // 
            ctrlShowLicense1.BackColor = Color.Gray;
            ctrlShowLicense1.Location = new Point(2, 50);
            ctrlShowLicense1.Name = "ctrlShowLicense1";
            ctrlShowLicense1.Size = new Size(1148, 384);
            ctrlShowLicense1.TabIndex = 4;
            // 
            // ctrlFindLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(tbSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(ctrlShowLicense1);
            Name = "ctrlFindLicense";
            Size = new Size(1148, 430);
            Load += ctrlFindLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private ctrlShowLicense ctrlShowLicense1;
    }
}
