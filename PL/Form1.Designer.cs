namespace PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            applicatonsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            reNewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replacementForLostOrDamegedToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            manageDetainLicensesToolStripMenuItem = new ToolStripMenuItem();
            releaseDitainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            userInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            singoutToolStripMenuItem = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, applicatonsToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, settingsToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1816, 28);
            msMain.TabIndex = 2;
            msMain.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(68, 24);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // applicatonsToolStripMenuItem
            // 
            applicatonsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicenseToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicenseToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            applicatonsToolStripMenuItem.Name = "applicatonsToolStripMenuItem";
            applicatonsToolStripMenuItem.Size = new Size(102, 24);
            applicatonsToolStripMenuItem.Text = "Applicatons";
            // 
            // drivingLicenseToolStripMenuItem
            // 
            drivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, reNewDrivingLicenseToolStripMenuItem, replacementForLostOrDamegedToolStripMenuItem });
            drivingLicenseToolStripMenuItem.Name = "drivingLicenseToolStripMenuItem";
            drivingLicenseToolStripMenuItem.Size = new Size(268, 26);
            drivingLicenseToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(316, 26);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(228, 26);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(228, 26);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // reNewDrivingLicenseToolStripMenuItem
            // 
            reNewDrivingLicenseToolStripMenuItem.Name = "reNewDrivingLicenseToolStripMenuItem";
            reNewDrivingLicenseToolStripMenuItem.Size = new Size(316, 26);
            reNewDrivingLicenseToolStripMenuItem.Text = "Re-New Driving License";
            reNewDrivingLicenseToolStripMenuItem.Click += reNewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replacementForLostOrDamegedToolStripMenuItem
            // 
            replacementForLostOrDamegedToolStripMenuItem.Name = "replacementForLostOrDamegedToolStripMenuItem";
            replacementForLostOrDamegedToolStripMenuItem.Size = new Size(316, 26);
            replacementForLostOrDamegedToolStripMenuItem.Text = "Replacement for lost or dameged";
            replacementForLostOrDamegedToolStripMenuItem.Click += replacementForLostOrDamegedToolStripMenuItem_Click;
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationsToolStripMenuItem, internationalDrivingLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(268, 26);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            manageApplicationsToolStripMenuItem.Click += manageApplicationsToolStripMenuItem_Click;
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            localDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(367, 26);
            localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationsToolStripMenuItem.Click += localDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(367, 26);
            internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License Applications";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Click += internationalDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detainLicenseToolStripMenuItem1, manageDetainLicensesToolStripMenuItem, releaseDitainedLicenseToolStripMenuItem });
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(268, 26);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // detainLicenseToolStripMenuItem1
            // 
            detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            detainLicenseToolStripMenuItem1.Size = new Size(256, 26);
            detainLicenseToolStripMenuItem1.Text = "Detain License";
            detainLicenseToolStripMenuItem1.Click += detainLicenseToolStripMenuItem1_Click;
            // 
            // manageDetainLicensesToolStripMenuItem
            // 
            manageDetainLicensesToolStripMenuItem.Name = "manageDetainLicensesToolStripMenuItem";
            manageDetainLicensesToolStripMenuItem.Size = new Size(256, 26);
            manageDetainLicensesToolStripMenuItem.Text = "Manage Detain Licenses";
            manageDetainLicensesToolStripMenuItem.Click += manageDetainLicensesToolStripMenuItem_Click;
            // 
            // releaseDitainedLicenseToolStripMenuItem
            // 
            releaseDitainedLicenseToolStripMenuItem.Name = "releaseDitainedLicenseToolStripMenuItem";
            releaseDitainedLicenseToolStripMenuItem.Size = new Size(256, 26);
            releaseDitainedLicenseToolStripMenuItem.Text = "Release Ditained License";
            releaseDitainedLicenseToolStripMenuItem.Click += releaseDitainedLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(268, 26);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(268, 26);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(69, 24);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userInfoToolStripMenuItem, changePasswordToolStripMenuItem, singoutToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // userInfoToolStripMenuItem
            // 
            userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            userInfoToolStripMenuItem.Size = new Size(207, 26);
            userInfoToolStripMenuItem.Text = "User Info";
            userInfoToolStripMenuItem.Click += userInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(207, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // singoutToolStripMenuItem
            // 
            singoutToolStripMenuItem.Name = "singoutToolStripMenuItem";
            singoutToolStripMenuItem.Size = new Size(207, 26);
            singoutToolStripMenuItem.Text = "Sing out";
            singoutToolStripMenuItem.Click += singoutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1816, 761);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Controls.SetChildIndex(msMain, 0);
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem applicatonsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem userInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem singoutToolStripMenuItem;
        private ToolStripMenuItem drivingLicenseToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem reNewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replacementForLostOrDamegedToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private ToolStripMenuItem manageDetainLicensesToolStripMenuItem;
        private ToolStripMenuItem releaseDitainedLicenseToolStripMenuItem;
    }
}
