namespace PL
{
    partial class frmEditTestTypes
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
            btnCancel = new Button();
            btnUpdate = new Button();
            lblName = new Label();
            tbFees = new TextBox();
            lblID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDescription = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(124, 387);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(349, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(373, 239);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 24);
            lblName.TabIndex = 15;
            lblName.Text = "??";
            // 
            // tbFees
            // 
            tbFees.Location = new Point(349, 325);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(125, 27);
            tbFees.TabIndex = 14;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(349, 199);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 24);
            lblID.TabIndex = 13;
            lblID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(124, 239);
            label4.Name = "label4";
            label4.Size = new Size(160, 24);
            label4.TabIndex = 12;
            label4.Text = "Test Type Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(124, 286);
            label3.Name = "label3";
            label3.Size = new Size(211, 24);
            label3.TabIndex = 11;
            label3.Text = "Test Type Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(124, 199);
            label2.Name = "label2";
            label2.Size = new Size(135, 24);
            label2.TabIndex = 10;
            label2.Text = "Test Type ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(317, 89);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 9;
            label1.Text = "Update Test Types";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(349, 286);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(125, 27);
            tbDescription.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(124, 328);
            label5.Name = "label5";
            label5.Size = new Size(148, 24);
            label5.TabIndex = 18;
            label5.Text = "Test Type Fees:";
            // 
            // frmEditTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDescription);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblName);
            Controls.Add(tbFees);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditTestTypes";
            Text = "frmEditTestTypes";
            Load += frmEditTestTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Label lblName;
        private TextBox tbFees;
        private Label lblID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDescription;
        private Label label5;
    }
}