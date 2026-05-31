namespace PL
{
    partial class frmEditApplicationTypes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblID = new Label();
            tbFees = new TextBox();
            lblName = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(266, 89);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 0;
            label1.Text = "Update Application Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 193);
            label2.Name = "label2";
            label2.Size = new Size(199, 24);
            label2.TabIndex = 1;
            label2.Text = "Application Type ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 280);
            label3.Name = "label3";
            label3.Size = new Size(212, 24);
            label3.TabIndex = 2;
            label3.Text = "Application Type Fees:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(101, 233);
            label4.Name = "label4";
            label4.Size = new Size(224, 24);
            label4.TabIndex = 3;
            label4.Text = "Application Type Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(326, 193);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 24);
            lblID.TabIndex = 4;
            lblID.Text = "??";
            // 
            // tbFees
            // 
            tbFees.Location = new Point(326, 278);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(125, 27);
            tbFees.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(350, 233);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 24);
            lblName.TabIndex = 6;
            lblName.Text = "??";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(326, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(101, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblName);
            Controls.Add(tbFees);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditApplicationTypes";
            Text = "frmEditApplicationTypes";
            Load += frmEditApplicationTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblID;
        private TextBox tbFees;
        private Label lblName;
        private Button btnUpdate;
        private Button btnCancel;
    }
}