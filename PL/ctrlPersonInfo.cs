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
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();

        }

        clsPerson Person = new clsPerson();

        public void FillForm(int PersonID)
        {
            Person = clsPerson.getPersonByID(PersonID);

            if (Person != null && Person.PersonID > 0)
            {
                lblPersonID.Text = Person.PersonID.ToString();
                lblNN.Text = Person.NationalNumber;
                lblFullName.Text = Person.getFullName();
                dtpDateOfBirth.Value = Person.DateOfBirth;
                lblGender.Text = (Person.Gender == 0) ? "Male" : "Female";
                lblAddress.Text = Person.Address;
                lblPhone.Text = Person.Phone;
                lblEmail.Text = Person.Email;
                string countryName = Person.getNationallityName();
                lblNationallity.Text = countryName ?? "N/A";
                ChooseImage();
            }

        }

        public void ChooseImage()
        {


            if (Person.ImagePath != "" && Person.ImagePath != null)
            {
                if (System.IO.File.Exists(clsHelper.imagesFolder + Person.ImagePath))
                    pbPerson.ImageLocation = clsHelper.imagesFolder + Person.ImagePath;
                else
                    MessageBox.Show("Could not find image at: " + Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _chooseGenderImage();
            }
        }

        private void _chooseGenderImage()
        {
            if (Person.Gender == 0)
            {
                pbPerson.Image = Resources.person_man;
            }
            else if (Person.Gender == 1)
            {
                pbPerson.Image = Resources.person_woman;
            }
        }

        private void linklblUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(Person.PersonID);
            frm.ShowDialog();
            FillForm(Person.PersonID);
        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
