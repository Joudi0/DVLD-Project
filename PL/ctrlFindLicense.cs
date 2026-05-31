using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class ctrlFindLicense : UserControl
    {
        public ctrlFindLicense()
        {
            InitializeComponent();
        }

        private void ctrlFindLicense_Load(object sender, EventArgs e)
        {

        }

        public int LicenseID = -1;
        public void Search(int LID = -1)
        {
            if(LID < 0)
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    MessageBox.Show("License ID Should not be empty");
                    return;
                }
                if (int.TryParse(tbSearch.Text, out int result))
                {
                    if (!clsLicense.isLicenseExistByID(result))
                    {
                        MessageBox.Show("License ID Not found");
                        return;
                    }
                    ctrlShowLicense1.fillForm(result);
                    LicenseID = result;
                    return;
                }
                else
                {
                    MessageBox.Show("ID Should be a Number");
                    LicenseID = -1;
                    return;
                }
            }
            else
            {
                ctrlShowLicense1.fillForm(LID);
                LicenseID = LID;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
