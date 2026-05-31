using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace PL
{
    public partial class frmEditTestTypes : Form
    {
        public frmEditTestTypes()
        {
            InitializeComponent();
        }

        private bool _check()
        {
            return !(clsHelper.hasChars(tbFees) || clsHelper.isEmpty(tbFees) || clsHelper.isEmpty(tbDescription));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        clsTestType type = new clsTestType();

        public void fillForm(int testTypeID)
        {
            type = clsTestType.getTestTypeByID(testTypeID);
            if (type != null)
            {
                lblID.Text = type.TestTypeID.ToString();
                lblName.Text = type.TestTypeTitle;
                tbDescription.Text = type.TestTypeDescription;
                tbFees.Text = type.TestTypeFees.ToString();
            }
        }

        private bool _update()
        {
            type.TestTypeDescription = tbDescription.Text;
            type.TestTypeFees = Convert.ToDecimal(tbFees.Text);
            return type.updateTestType();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_check())
            {
                if (_update())
                {
                    btnCancel.Text = "Close";
                    MessageBox.Show("Test Type Updated Successfully!.");
                }
                else
                {
                    MessageBox.Show("Updat Failed.");
                }
            }
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
