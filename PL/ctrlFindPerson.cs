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
using static System.Net.Mime.MediaTypeNames;
namespace PL
{

    public partial class ctrlFindPerson : UserControl
    {
        public class Item
        {
            public int index = -1;
            public string name = "";
            public Item(int index, string name)
            {
                this.index = index;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

        public ctrlFindPerson()
        {
            InitializeComponent();
            cbOptions.Items.Clear();
            cbOptions.Items.Add(new Item(0, "None"));
            cbOptions.Items.Add(new Item(1, "PersonID"));
            cbOptions.Items.Add(new Item(6, "NationalNo"));
            cbOptions.Items.Add(new Item(8, "Phone"));

        }

        private clsHelper.enPersonFilters filter = clsHelper.enPersonFilters.None;
        private int PersonID = -1;
        public delegate void DataBackEventHandler(int PersonID);

        public event DataBackEventHandler? OnFindPerson;

        private void _showFilterTextBox()
        {

            Item SelectedItem = (Item)cbOptions.SelectedItem;
            if (SelectedItem == null) return;
            switch (SelectedItem.index)
            {
                case (int)clsHelper.enPersonFilters.None:
                    {
                        filter = clsHelper.enPersonFilters.None;
                        tbFilter.Text = string.Empty;
                        tbFilter.Visible = false;
                        cbNationality.Visible = false;
                        tbFilter.Tag = string.Empty;
                        button1.Visible = false;
                        return;
                    }
                case (int)clsHelper.enPersonFilters.PersonID:
                    {
                        filter = clsHelper.enPersonFilters.PersonID;
                        tbFilter.Tag = "Person ID";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.NationalNumber:
                    {
                        filter = clsHelper.enPersonFilters.NationalNumber;
                        tbFilter.Tag = "National Number";
                        break;
                    }
                case (int)clsHelper.enPersonFilters.Phone:
                    {
                        filter = clsHelper.enPersonFilters.Phone;
                        tbFilter.Tag = "Phone";
                        clsHelper.checkPhone(tbFilter);
                        break;
                    }
                default: break;
            }
            tbFilter.Visible = true;
            cbNationality.Visible = false;
            button1.Visible = true; ;
        }

        private bool _filter()
        {
            if (!clsHelper.personErrorMessages(tbFilter, (int)filter)) return false;

            switch(filter)
            {
                case clsHelper.enPersonFilters.None:
                    button1.Visible = false;
                    return false;
                case clsHelper.enPersonFilters.PersonID:
                    button1.Visible = true;
                    return _searchWithPersonID();
                case clsHelper.enPersonFilters.NationalNumber:
                    button1.Visible = true;
                    return _searchWithNN();
                case clsHelper.enPersonFilters.Phone:
                    return _searchWithPhone();
                default:
                    PersonID = -1;
                    return false;
            }
        }

        public void fillWithPersonID(int pID)
        {
            tbFilter.Visible = true;
            cbNationality.Visible = false;
            button1.Visible = true; ;
            tbFilter.Text = pID.ToString();
            cbOptions.SelectedIndex = 1;

        }

        private bool _searchWithPersonID()
        {

            if (tbFilter.Text.Length > 0 && !clsHelper.hasChars(tbFilter))
            {

                if (int.TryParse(tbFilter.Text, out int searchID))
                {
                    clsPerson Person = clsPerson.getPersonByID(searchID);
                    if (Person != null)
                    {
                        PersonID = Person.PersonID;
                        return true;
                    }

                }

                return false;

            }
            return false;
        }

        private bool _searchWithNN()
        {
            if (tbFilter.Text.Length > 0)
            {
                clsPerson Person = clsPerson.getPersonByNationalNumber(tbFilter.Text);
                if (Person != null)
                {
                    PersonID = Person.PersonID;
                    return true;
                }
            }
            return false;
        }

        private bool _searchWithPhone()
        {

            if (tbFilter.Text.Length > 0)
            {

                clsPerson Person = clsPerson.getPersonByPhone(tbFilter.Text);
                if (Person != null)
                {
                    PersonID = Person.PersonID;
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonID = -1;
            if (!_filter())
            {
                MessageBox.Show("This Person is not exists");
            }
            else
            {

                OnFindPerson?.Invoke(PersonID);
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = "";
            _showFilterTextBox();
        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
