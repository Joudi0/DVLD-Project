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
    public partial class frmEditApplicationTypes : Form
    {
        public frmEditApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;

        }
        private clsApplicationType _type = new clsApplicationType();
        private clsApplicationType _getTypeByID(int id)
        {
            return clsApplicationType.getApplicationTypeByID(id);
        }
        private bool _check()
        {
            return !clsHelper.hasChars(tbFees) && !clsHelper.isEmpty(tbFees);
        }
        private bool _update()
        {
            _type.ApplicationFees = Convert.ToDecimal(tbFees.Text);
            return _type.updateApplicationType();
        }
        public void fillForm(int typeID)
        {
            _type = _getTypeByID(typeID);
            lblID.Text = _type.ApplicationTypeID.ToString();
            lblName.Text = _type.ApplicationTypeTitle;
            tbFees.Text = _type.ApplicationFees.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_check())
            {
                if (_update())
                {
                    MessageBox.Show("Type Fees Updated Successfully");
                    btnCancel.Text = "Close";
                }
                else MessageBox.Show("Update Failed");


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
