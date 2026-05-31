using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PL
{
    public partial class ctrlAddUpdatePerson : UserControl
    {


        public ctrlAddUpdatePerson()
        {
            InitializeComponent();
            cbNationality.DataSource = clsCountry.getAllCountries();
            cbNationality.DisplayMember = "CountryName";
            if (cbNationality.SelectedIndex < 0) cbNationality.SelectedIndex = cbNationality.FindString("United Arab Emirates");
        }

        public clsPerson Person = new clsPerson();

        public bool getPersonByID(int PersonID)
        {
            Person = clsPerson.getPersonByID(PersonID);
            if(Person == null )
            {
                Person = new clsPerson();
                return false;
            }
            else
            {
                label.Text = "Update Person ID: " + PersonID;
                _FillForm();
                return true;
            }
        }

        private void _FillForm()
        {
            tbNN.Text = Person.NationalNumber;
            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            if(Person.ThirdName == "" || Person.ThirdName == null)
            {
                tbThirdName.Text = string.Empty;
            }
            else
            {
                tbThirdName.Text = Person.ThirdName;
            }
            tbLastName.Text = Person.LastName;

            cbNationality.SelectedIndex = cbNationality.FindString(Person.getNationallityName());
            tbEmail.Text = Person.Email;
            tbPhone.Text = Person.Phone;
            if(string.IsNullOrEmpty(Person.ImagePath))
            {
                _chooseGenderImage();
            }
            else
            {
                pbImage.ImageLocation = clsHelper.imagesFolder + Person.ImagePath;
            }
            dtp.Value = Person.DateOfBirth;
            tbAddress.Text = Person.Address;
            _FillGender();
        }

        private void _FillGender()
        {
            if (Person.Gender == 0)
            {
                rbMale.Checked = true;
            }
            else if (Person.Gender == 1)
            {
                rbFemale.Checked = true;
            }
        }

        ErrorProvider errorProvider = new ErrorProvider();

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler? OnCancelClick;

        public delegate void PersonIDEventHandler(int PersonID);

        public event PersonIDEventHandler? OnAdd;

        private string _sourceFile = string.Empty;

        private string _destinationFile = string.Empty;

        private string _oldFile = string.Empty;

        private void ctrlAddUpdate_Load(object sender, EventArgs e)
        {

        }

        private bool _Save()
        {
            if (_checkAllForm())
            {
                _chooseImage();
                _savePerson();

                if (Person.Save())
                {
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!string.IsNullOrEmpty(pbImage.ImageLocation)) // source
                    {
                        _SaveImage();
                    }
                    label.Text = "Update Person ID: " + Person.PersonID.ToString();
                    btnCancel.Text = "Close";
                    OnAdd?.Invoke(Person.PersonID);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error: Data was not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void _savePerson()
        {
            Person.NationalNumber = tbNN.Text;
            Person.FirstName = tbFirstName.Text;
            Person.SecondName = tbSecondName.Text;
            Person.ThirdName = tbThirdName.Text;
            Person.LastName = tbLastName.Text;
            _chooseGender();
            Person.Phone = tbPhone.Text;
            Person.Email = tbEmail.Text;
            Person.Address = tbAddress.Text;
            Person.DateOfBirth = dtp.Value;
            Person.CountryID = cbNationality.SelectedIndex + 1;
        }

        private bool _checkAllForm()
        {
            bool check = _checkFullName() && clsHelper.checkPhone(tbPhone) && clsHelper.checkEmail(tbEmail) && _checkGender() && clsHelper.checkNationalNumber(tbNN, Person.NationalNumber) && !clsHelper.isEmpty(tbAddress);
            return check;
        }

        private bool _checkGender()
        {
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                errorProvider.SetError(panel, "You should choose your gender");
                return false;
            }
            else
            {
                errorProvider.SetError(panel, "");
                return true;
            }
        }

        private bool _checkFullName()
        {
            return (clsHelper.checkName(tbFirstName) && clsHelper.checkName(tbSecondName) && !clsHelper.hasNumbers(tbThirdName) && tbThirdName.Text.Length <= 25 && clsHelper.checkName(tbLastName));
        }

        private void _chooseImage()
        {
            if (string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                _chooseGenderImage();
            }
            else
            {
                _savePersonalImage();
            }
        }

        private void _setPersonalImage()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openFileDialog1.FileName;

                pbImage.ImageLocation = selectedFilePath;

            }
        }

        private bool _SaveImage()
        {
            try
            {
                File.Copy(_sourceFile, _destinationFile, true);
                if (File.Exists(_oldFile))
                {
                    File.Delete(_oldFile);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Saving Image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Person.ImagePath = "";
                return false;
            }
            return true;
        }

        private void _chooseGender()
        {
            if (rbMale.Checked)
            {
                Person.Gender = 0;
            }
            else if (rbFemale.Checked)
            {
                Person.Gender = 1;
            }
        }

        private void _chooseGenderImage()
        {
            if (rbMale.Checked)
            {
                pbImage.Image = Resources.person_man;
                Person.ImagePath = "";
            }
            else if (rbFemale.Checked)
            {
                pbImage.Image = Resources.person_woman;
                Person.ImagePath = "";
            }
        }

        private void _savePersonalImage()
        {

            if (!Directory.Exists(clsHelper.imagesFolder))
            {
                Directory.CreateDirectory(clsHelper.imagesFolder);
            }
            string sourceFile = pbImage.ImageLocation;

            string extension = Path.GetExtension(sourceFile);

            string newFileName = Guid.NewGuid().ToString() + extension;

            _oldFile = clsHelper.imagesFolder + Person.ImagePath;

            Person.ImagePath = newFileName;

            string destinationFile = Path.Combine(clsHelper.imagesFolder, newFileName);
            _sourceFile = sourceFile;
            _destinationFile = destinationFile;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _setPersonalImage();
        }

        private void _deleteImage()
        {
            Person.ImagePath = "";
            pbImage.ImageLocation = "";
            pbImage.Image = null;
            _chooseGenderImage();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _deleteImage();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                _chooseGenderImage();
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                _chooseGenderImage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelClick?.Invoke();
        }
    }
}
