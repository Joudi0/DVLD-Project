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
    public partial class frmTestTypes : Form
    {
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void _refresh()
        {
            dgv.DataSource = clsTestType.getAll();

        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            _refresh();
            if (dgv.Columns.Contains("TestTypeID"))
                dgv.Columns["TestTypeID"].Width = 90;
            if (dgv.Columns.Contains("TestTypeFees"))
                dgv.Columns["TestTypeFees"].Width = 111;
            if (dgv.Columns.Contains("TestTypeTitle"))
                dgv.Columns["TestTypeTitle"].Width = 150;
            if (dgv.Columns.Contains("TestTypeDescription"))
                dgv.Columns["TestTypeDescription"].Width = 400;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedTestTypeID = (int)dgv.CurrentRow.Cells[0].Value;
            frmEditTestTypes frm = new frmEditTestTypes();
            frm.fillForm(SelectedTestTypeID);
            frm.ShowDialog();
            _refresh();

        }
    }
}
