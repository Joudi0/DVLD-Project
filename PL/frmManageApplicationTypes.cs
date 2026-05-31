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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            dgv.DataSource = clsApplicationType.getAll();
            if (dgv.Columns.Contains("ApplicationTypeID"))
                dgv.Columns["ApplicationTypeID"].Width = 111;
            if (dgv.Columns.Contains("ApplicationTypeFees"))
                dgv.Columns["ApplicationTypeFees"].Width = 111;
            if (dgv.Columns.Contains("ApplicationTypeTitle"))
                dgv.Columns["ApplicationTypeTitle"].Width = 310;
        }
        private void _refresh()
        {
            dgv.DataSource = clsApplicationType.getAll();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int SelectedTypeID = (int)dgv.CurrentRow.Cells[0].Value;

            frmEditApplicationTypes frm = new frmEditApplicationTypes();
            frm.fillForm(SelectedTypeID);
            frm.ShowDialog();
            _refresh();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
