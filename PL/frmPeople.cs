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
namespace PL
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        clsHelper.enPersonFilters filter = clsHelper.enPersonFilters.None;

        DataTable dt = clsPerson.getAllPeople();

        private DataView _dv;

        private void frmPeople_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            cb.SelectedIndex = 0;
            _refreshDataView();
        }

        private void _RefreshPeopleList()
        {
            string currentFilter = _dv.RowFilter;

            dt = clsPerson.getAllPeople();

            _dv = dt.DefaultView;

            _dv.RowFilter = currentFilter;

            dgv.DataSource = _dv;
            lblRecords.Text = $"# Records: {_dv.Count}";
        }

        private void _refreshData()
        {
            dt = clsPerson.getAllPeople();
            lblRecords.Text = $"# Records: {dt.Rows.Count}";
        }

        private void _refreshDataView()
        {
            _dv = dt.DefaultView;
            dgv.DataSource = _dv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            int SelectedPersonID = (int)dgv.CurrentRow.Cells[0].Value;
            frm.getPersonByID(SelectedPersonID);
            frm.ShowDialog();
            _refreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = (int)dgv.CurrentRow.Cells[0].Value;
            clsPerson Person = clsPerson.getPersonByID(SelectedPersonID);
            string oldFile = clsHelper.imagesFolder + Person.ImagePath;
            if (clsPerson.removePerson(SelectedPersonID))
            {
                _refreshData();
            }
            else
            {
                MessageBox.Show("Cannot delete this person because they are linked to other data in the system. Please delete the related records first");
            }
            if (File.Exists(oldFile))
            {
                File.Delete(oldFile);
            }

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = (int)dgv.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(SelectedPersonID);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            _showFilterTextBox();
        }

        private void _showFilterTextBox()
        {
            switch (cb.SelectedIndex)
            {
                case (int)clsHelper.enPersonFilters.None:
                    {
                        filter = clsHelper.enPersonFilters.None;
                        tbFilter.Text = string.Empty;
                        tbFilter.Visible = false;
                        cbNationality.Visible = false;
                        tbFilter.Tag = string.Empty;
                        return;
                    }
                case (int)clsHelper.enPersonFilters.PersonID:
                    {
                        filter = clsHelper.enPersonFilters.PersonID;;
                        tbFilter.Tag = "Person ID";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.NationalNumber:
                    {
                        filter = clsHelper.enPersonFilters.NationalNumber;
                        tbFilter.Tag = "National Number";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.FirstName:
                    {
                        filter = clsHelper.enPersonFilters.FirstName;
                        tbFilter.Tag = "First Name";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.SecondName:
                    {
                        filter = clsHelper.enPersonFilters.SecondName;
                        tbFilter.Tag = "Second Name";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.ThirdName:
                    {
                        filter = clsHelper.enPersonFilters.ThirdName;
                        tbFilter.Tag = "Third Name";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.LastName:
                    {
                        filter = clsHelper.enPersonFilters.LastName;
                        tbFilter.Tag = "Last Name";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.Gender:
                    {
                        filter = clsHelper.enPersonFilters.Gender;
                        tbFilter.Tag = "Gender";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.Phone:
                    {
                        filter = clsHelper.enPersonFilters.Phone;
                        tbFilter.Tag = "Phone";
                        clsHelper.checkPhone(tbFilter);
                        break;
                    }
                case (int)clsHelper.enPersonFilters.Email:
                    {
                        filter = clsHelper.enPersonFilters.Email;
                        tbFilter.Tag = "Email";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.Nationality:
                    {
                        filter = clsHelper.enPersonFilters.Nationality;
                        tbFilter.Visible = false;
                        cbNationality.Visible = true;
                        clsHelper.getAllCountries(cbNationality);
                        return;
                    }
                default: break;
            }
            tbFilter.Visible = true;
            cbNationality.Visible = false;
        }

        private void _filter()
        {
            if (!clsHelper.personErrorMessages(tbFilter, cb.SelectedIndex))
            {
                _dv.RowFilter = "";
                _refreshDataView();

                return;
            }
            string query = string.Empty;
            string filterName = clsHelper.GetPersonColumnName(filter);

            if (filterName == string.Empty || filterName == "")
            {
                _dv.RowFilter = query;
                return;
            }

            else if (filterName == "PersonID")
            {
                if (tbFilter.Text.Length > 0)
                {
                    query = $"[{filterName}] = {tbFilter.Text.Trim()}";
                    if(!clsHelper.hasChars(tbFilter))
                    {
                        _dv.RowFilter = query;

                    }
                    _refreshDataView();

                }
            }

            else if (filterName == "Gendor")
            {
                byte gender = 2;
                if (tbFilter.Text.Trim().ToUpper() == "M" || tbFilter.Text.Trim().ToUpper() == "MALE")
                {
                    gender = 0;
                }
                else if (tbFilter.Text.Trim().ToUpper() == "F" || tbFilter.Text.Trim().ToUpper() == "FEMALE")
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                query = $"[{filterName}] = {gender}";
                _dv.RowFilter = query;
                _refreshDataView();
            }

            else
            {
                query = $"[{filterName}] LIKE '{tbFilter.Text.Trim()}%'";
                _dv.RowFilter = query;
                _refreshDataView();
            }

        }

        private void _filterNationality()
        {
            string filterName = clsHelper.GetPersonColumnName(filter);
            if (filterName == "NationalityCountryID")
            {
                string query = $"[{filterName}] = {cbNationality.SelectedIndex + 1}";
                _dv.RowFilter = query;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _filter();
        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterNationality();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.filterPersonTextBox(e, tbFilter, filter);
        }
    }
}
