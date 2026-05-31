using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    
    public class clsHelper
    {
        public enum enPersonFilters
        {
            None = 0, PersonID,
            FirstName, SecondName, ThirdName, LastName, NationalNumber, Gender,
            Phone, Email, Nationality
        }
        public enum enUserFilters
        {
            None = 0, UserID, Username, PersonID, FullName, isActive
        }

        public enum enLicenseApplication
        {
            None = 0, laID, NationalNo, FullName, Status
        }

        public static string imagesFolder = @"C:\DVLD_People_Images\";

        public static ErrorProvider errorProvider = new ErrorProvider();

        public static clsUser user = new clsUser(); // current system user

        public static string GetPersonColumnName(enPersonFilters filter)
        {
            switch (filter)
            {
                case enPersonFilters.PersonID: return "PersonID";
                case enPersonFilters.NationalNumber: return "NationalNo";
                case enPersonFilters.FirstName: return "FirstName";
                case enPersonFilters.SecondName: return "SecondName";
                case enPersonFilters.ThirdName: return "ThirdName";
                case enPersonFilters.LastName: return "LastName";
                case enPersonFilters.Phone: return "Phone";
                case enPersonFilters.Email: return "Email";
                case enPersonFilters.Gender: return "Gendor";
                case enPersonFilters.Nationality: return "NationalityCountryID";
                case enPersonFilters.None: return "";
                default: return "";
            }
        }

        public static string GetUserColumnName(enUserFilters filter)
        {
            switch (filter)
            {
                case enUserFilters.None: return "";
                case enUserFilters.UserID: return "UserID";
                case enUserFilters.Username: return "UserName";
                case enUserFilters.PersonID: return "PersonID";
                case enUserFilters.FullName: return "FullName";
                case enUserFilters.isActive: return "isActive";
                default: return "";
            }
        }

        public static bool ValidateInput(TextBox tb, string validationMode, string nationalNoForUpdate = "")
        {
            errorProvider.SetError(tb, "");

            switch (validationMode)
            {
                case "Numeric":
                    return !isEmpty(tb) && !hasChars(tb);

                case "Alpha":
                    return checkName(tb);

                case "NationalNo":
                    return checkNationalNumber(tb, nationalNoForUpdate);

                case "Phone":
                    return checkPhone(tb);

                case "Email":
                    return checkEmail(tb);

                case "Password":
                    return !isEmpty(tb) && !shortPassword(tb);

                case "Mixed":
                    return !isEmpty(tb) && !isLong(tb);

                default:
                    return true;
            }
        }

        public static bool checkName(TextBox tb)
        {
            return !hasNumbers(tb) && !isEmpty(tb) && !isLong(tb);
        }
        public static void SmartKeyPress(KeyPressEventArgs e, string mode)
        {
            if (mode == "Numeric") olnyNumbers(e);
            else if (mode == "Alpha") onlyCharacters(e);
        }

        public static bool checkNationalNumber(TextBox tbNN, string NN = "")
        {
            bool check = true;
            if (isEmpty(tbNN))
            {
                check = false;
            }
            else if (NN != "" && NN != null && NN != string.Empty && !clsPerson.isNationalNoUnique(tbNN.Text) && tbNN.Text != NN)
            {
                errorProvider.SetError(tbNN, "This National Number is already exists");
                check = false;
            }
            return check;
        }

        public static bool isLong(TextBox tb)
        {
            if(tb.Text.Length > 25)
            {
                errorProvider.SetError(tb, $"{tb.Tag} should be less than or equal 25 character");
                return true;
            }
            return false;

        }
        public static bool checkPhone(TextBox tbPhone)
        {
            bool isNineNumbers = (tbPhone.Text.Length == 9);
            if (isEmpty(tbPhone)) return false;
            if (hasChars(tbPhone))
            {
                return false;
            }
            if (!isNineNumbers)
            {
                errorProvider.SetError(tbPhone, "Phone Number should contain 9 numbers");
                return false;
            }
            return true;
        }
        public static bool checkEmail(TextBox tbEmail)
        {
            if (tbEmail.Text == string.Empty || tbEmail.Text == null || tbEmail.Text == "") return true;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(tbEmail.Text, emailPattern))
            {
                errorProvider.SetError(tbEmail, "Email's Format is not correct, example: name@example.com");
                return false;
            }
            else
            {
                errorProvider.SetError(tbEmail, "");
                return true;

            }
        }
        public static bool hasChars(TextBox tb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, @"\p{L}"))
            {
                errorProvider.SetError(tb, $"{tb.Tag} Should not contain Characters");
                return true;
            }
            else
            {
                errorProvider.SetError(tb, "");
                return false;
            }
        }
        public static bool isEmpty(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                errorProvider.SetError(tb, $"{tb.Tag} should not be empty");
                return true;
            }
            else
            {
                errorProvider.SetError(tb, "");
                return false;
            }
        }
        public static bool hasNumbers(TextBox tb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, @"\d+"))
            {
                errorProvider.SetError(tb, $"{tb.Tag} Should not contain numbers");
                return true;
            }
            else
            {
                errorProvider.SetError(tb, "");
                return false;
            }

        }
        public static bool shortPassword(TextBox tbPassword)
        {
            if (tbPassword.Text.Length < 4)
            {
                errorProvider.SetError(tbPassword, "Password should be 4 characters or more");
                return true;
            }
            return false;
        }

        public static void onlyCharacters(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void olnyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void dropChar(KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public static void filterPersonTextBox(KeyPressEventArgs e, TextBox tbFilter, enPersonFilters filter)
        {
            switch (filter)
            {
                case enPersonFilters.PersonID:
                    {
                        olnyNumbers(e);

                        break;
                    }
                case enPersonFilters.NationalNumber:
                    {
                        if (isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.FirstName:
                    {
                        onlyCharacters(e);
                        if (hasNumbers(tbFilter) || isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.SecondName:
                    {
                        onlyCharacters(e);
                        if (hasNumbers(tbFilter) || isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.ThirdName:
                    {
                        onlyCharacters(e);
                        if (hasNumbers(tbFilter) || isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.LastName:
                    {
                        onlyCharacters(e);
                        if (hasNumbers(tbFilter) || isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.Gender:
                    {
                        onlyCharacters(e);
                        break;
                    }
                case enPersonFilters.Phone:
                    {
                        olnyNumbers(e);
                        if (hasChars(tbFilter) || isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enPersonFilters.Email:
                    {
                        if (isLong(tbFilter)) dropChar(e);
                        break;
                    }
                default: break;
            }
        }

        public static void filterUserTextBox(KeyPressEventArgs e, TextBox tbFilter, enUserFilters filter)
        {
            switch (filter)
            {
                case enUserFilters.PersonID:
                    {
                        olnyNumbers(e);
                        break;
                    }
                case enUserFilters.UserID:
                    {
                        olnyNumbers(e);
                        break;
                    }
                case enUserFilters.Username:
                    {
                        if (isLong(tbFilter)) dropChar(e);
                        break;
                    }
                case enUserFilters.FullName:
                    {
                        onlyCharacters(e);
                        break;
                    }
                default: break;
            }
        }


        public static bool personErrorMessages(TextBox tbFilter, int cb)
        {
            bool isCorrect = false;
            switch (cb)
            {

                case (int)enPersonFilters.PersonID:
                    {
                        isCorrect = !clsHelper.hasChars(tbFilter);
                        break;
                    }
                case (int)enPersonFilters.NationalNumber:
                    {
                        isCorrect = clsHelper.checkNationalNumber(tbFilter) && !clsHelper.isLong(tbFilter);
                        break;
                    }
                case (int)enPersonFilters.FirstName:
                    {
                        isCorrect = clsHelper.checkName(tbFilter);
                        break;
                    }
                case (int)enPersonFilters.SecondName:
                    {
                        isCorrect = clsHelper.checkName(tbFilter);

                        break;
                    }
                case (int)enPersonFilters.ThirdName:
                    {
                        isCorrect = (!clsHelper.hasNumbers(tbFilter) && !clsHelper.isLong(tbFilter));
                        break;
                    }
                case (int)enPersonFilters.LastName:
                    {
                        isCorrect = clsHelper.checkName(tbFilter);

                        break;
                    }
                case (int)enPersonFilters.Gender:
                    {
                        isCorrect = (!clsHelper.hasNumbers(tbFilter) && !clsHelper.isLong(tbFilter));
                        break;
                    }
                case (int)enPersonFilters.Phone:
                    {
                        isCorrect = (!clsHelper.hasChars(tbFilter) && !clsHelper.isLong(tbFilter));

                        break;
                    }
                case (int)enPersonFilters.Email:
                    {
                        isCorrect = clsHelper.checkEmail(tbFilter);
                        break;
                    }
                default: break;
            }
            return isCorrect;
        }

        public static bool userErrorMessages(TextBox tbFilter, int cb)
        {
            bool isCorrect = false;
            switch (cb)
            {
                case (int)enUserFilters.UserID:
                case (int)enUserFilters.PersonID:
                    {
                        isCorrect = !clsHelper.hasChars(tbFilter) && !isEmpty(tbFilter);
                        break;
                    }
                case (int)enUserFilters.FullName:
                    {
                        isCorrect = !clsHelper.hasNumbers(tbFilter) && !isEmpty(tbFilter);
                        break;
                    }
                default: isCorrect = true; break ;
            }
            return isCorrect;
        }


        public static void getAllCountries(ComboBox cbNationality)
        {
            cbNationality.DataSource = clsCountry.getAllCountries();
            cbNationality.DisplayMember = "CountryName";
            cbNationality.SelectedIndex = cbNationality.FindString("United Arab Emirates");
        }
    }
}
