using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PL.clsHelper;

namespace PL
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dgv.CurrentRow.Cells[0].Value;

            frmUserInfo frm = new frmUserInfo(SelectedUserID);
            frm.ShowDialog();
        }
        enUserFilters filters = enUserFilters.None;

        clsHelper.enUserFilters filter = clsHelper.enUserFilters.None;

        DataTable _dt = clsUser.getAllUsers();

        private DataView _dv;

        private void _refreshData()
        {
            _dt = clsUser.getAllUsers();
            lblRecords.Text = $"# Records: {_dt.Rows.Count}";
        }

        private void _refreshDataView()
        {
            _dv = _dt.DefaultView;
            dgv.DataSource = _dv;
            if (dgv.Columns.Contains("FullName"))
            {
                dgv.Columns["FullName"].Width = 300;
            }
        }
        private void _RefreshUsersList()
        {
            string currentFilter = "";
            if (_dv.RowFilter != null) currentFilter = _dv.RowFilter;

            _dt = clsUser.getAllUsers();
            _dv = _dt.DefaultView;

            _dv.RowFilter = currentFilter;

            dgv.DataSource = _dv;
            lblRecords.Text = $"# Records: {_dv.Count}";
        }

        private void _Refresh()
        {
            _refreshData();
            _refreshDataView();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnAddNewuser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _Refresh();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dgv.CurrentRow.Cells[0].Value;
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.updateMode(SelectedUserID);
            frm.ShowDialog();
            _Refresh();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dgv.CurrentRow.Cells[0].Value;
            if (SelectedUserID == clsHelper.user.UserID)
            {
                MessageBox.Show("You cannot delete your account");
                return;
            }
            if (clsUser.removeUser(SelectedUserID))
            {
                MessageBox.Show("User deleted Successfully!.");
                _Refresh();
            }
            else
            {
                MessageBox.Show("User delete failed, please delete the related records first.");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _showFilterTextBox();
            tbFilter.Text = "";
            _refreshDataView();

        }

        private void _showFilterTextBox()
        {

            switch (cb.SelectedIndex)
            {
                case (int)clsHelper.enUserFilters.None:
                    {
                        filter = clsHelper.enUserFilters.None;
                        tbFilter.Text = string.Empty;
                        tbFilter.Visible = false;
                        chbIsActive.Visible = false;

                        tbFilter.Tag = string.Empty;
                        return;
                    }
                case (int)clsHelper.enUserFilters.UserID:
                    {
                        filter = clsHelper.enUserFilters.UserID; ;
                        tbFilter.Tag = "UserID ID";
                        break;
                    }
                case (int)clsHelper.enUserFilters.Username:
                    {
                        filter = clsHelper.enUserFilters.Username; ;
                        tbFilter.Tag = "Username";
                        break;
                    }
                case (int)clsHelper.enUserFilters.PersonID:
                    {
                        filter = clsHelper.enUserFilters.PersonID; ;
                        tbFilter.Tag = "Person ID";
                        break;
                    }

                case (int)clsHelper.enUserFilters.FullName:
                    {
                        filter = clsHelper.enUserFilters.FullName;
                        tbFilter.Tag = "FullName";
                        break;
                    }
                case (int)clsHelper.enUserFilters.isActive:
                    {
                        filter = clsHelper.enUserFilters.isActive;
                        tbFilter.Tag = "is Active";
                        tbFilter.Visible = false;
                        chbIsActive.Visible = true;
                        chbIsActive.Checked = true;
                        return;
                    }
                default: break;
            }
            tbFilter.Visible = true;
        }


        private void _filter()
        {
            if (tbFilter.Visible) if (!clsHelper.userErrorMessages(tbFilter, cb.SelectedIndex))
                {
                    _dv.RowFilter = "";
                    _refreshDataView();
                    return;
                }
            string query = string.Empty;
            string filterName = clsHelper.GetUserColumnName(filter);
            if (filterName == string.Empty || filterName == "")
            {
                _dv.RowFilter = query;
                return;
            }

            else if (filterName == "PersonID" || filterName == "UserID")
            {
                if (tbFilter.Text.Trim().Length > 0)
                {
                    if (!clsHelper.hasChars(tbFilter))
                    {
                        query = $"[{filterName}] = {tbFilter.Text.Trim()}";
                        _dv.RowFilter = query;

                    }


                }
                else
                {
                    _dv.RowFilter = "";
                    _refreshDataView();
                }

            }

            else if (filterName == "isActive")
            {
                byte isActive = 2;
                if (chbIsActive.Checked)
                {
                    isActive = 1;
                }
                else isActive = 0;
                query = $"[{filterName}] = {isActive}";
                _dv.RowFilter = query;
            }

            else
            {
                if (tbFilter.Text.Trim().Length > 0)
                {
                    query = $"[{filterName}] LIKE '{tbFilter.Text.Trim()}%'";
                    _dv.RowFilter = query;
                }
                else
                {
                    _dv.RowFilter = "";
                    _refreshDataView();
                }
            }

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _filter();

        }

        private void chbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _filter();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterUserTextBox(e, tbFilter, filter);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
