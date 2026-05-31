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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }
        DataTable _dt;
        DataView _dv = new DataView();
        int _PersonID = -1;
        private void _refresh()
        {
            dgvDrivers.DataSource = _dv;
            lblRecords.Text = $"# Records: {_dv.Count}";
        }
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _dt = clsDriver.getAllView();
            _dv = _dt.DefaultView;
            ctrlFindPerson1.OnFindPerson += filldgv;
            _refresh();
            if (dgvDrivers.Columns.Contains("FullName"))
                dgvDrivers.Columns["FullName"].Width = 350;

            if (dgvDrivers.Columns.Contains("NationalNo"))
                dgvDrivers.Columns["NationalNo"].Width = 150;

            if (dgvDrivers.Columns.Contains("PersonID"))
                dgvDrivers.Columns["PersonID"].Width = 100;
            if (dgvDrivers.Columns.Contains("CreatedDate"))
                dgvDrivers.Columns["CreatedDate"].Width = 200;
            if (dgvDrivers.Columns.Contains("NumberOfActiveLicenses"))
                dgvDrivers.Columns["NumberOfActiveLicenses"].Width = 200;

        }

        private void ctrlPersonInfoFilter_Load(object sender, EventArgs e)
        {

        }
        public int PersonID = -1;
        public void filldgv(int PersonID)
        {
            if (PersonID != -1)
            {
                _dv.RowFilter = $"PersonID = {PersonID}";
            }
            else
            {
                _dv.RowFilter = ""; 
            }

            _refresh();
        }
    }
}
