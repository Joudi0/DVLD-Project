namespace PL
{
    partial class ctrlFindPerson
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
            button1 = new Button();
            cbNationality = new ComboBox();
            tbFilter = new TextBox();
            cbOptions = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(354, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // cbNationality
            // 
            cbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNationality.FormattingEnabled = true;
            cbNationality.Location = new Point(197, 15);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(151, 28);
            cbNationality.TabIndex = 14;
            cbNationality.Visible = false;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(204, 17);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(125, 27);
            tbFilter.TabIndex = 13;
            tbFilter.Visible = false;
            // 
            // cbOptions
            // 
            cbOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOptions.FormattingEnabled = true;
            cbOptions.Items.AddRange(new object[] { "" });
            cbOptions.Location = new Point(3, 15);
            cbOptions.Name = "cbOptions";
            cbOptions.Size = new Size(151, 28);
            cbOptions.TabIndex = 12;
            cbOptions.SelectedIndexChanged += cbOptions_SelectedIndexChanged;
            // 
            // ctrlFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(button1);
            Controls.Add(cbNationality);
            Controls.Add(tbFilter);
            Controls.Add(cbOptions);
            Name = "ctrlFindPerson";
            Size = new Size(458, 52);
            Load += ctrlFindPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbNationality;
        private TextBox tbFilter;
        private ComboBox cbOptions;
    }
}
