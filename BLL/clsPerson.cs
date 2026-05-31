using DAL;
using System;
using System.Data;

namespace BLL
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; } 
        public string ThirdName { get; set; } 
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public byte Gender { get; set; } 
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        enum enMode { AddNew, Update }
        private enMode Mode;
        private clsPerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int CountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone; 
            this.Email = Email;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }

        public clsPerson()
        {
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }



        public string getFullName()
        {
            return this.FirstName + " " + this.SecondName + " " + this.ThirdName + " " + this.LastName;
        }

        public string getNationallityName()
        {
            return clsPersonDataLayer.getCountryName(this.CountryID);
        }

        public static bool isNationalNoUnique(string NN)
        {
            return clsPersonDataLayer.isNationalNoUnique(NN);
        }

        public static clsPerson getPersonByID(int id)
        {
            int PersonID = id;
            string NationalNumber = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int CountryID = 0;
            string ImagePath = string.Empty;

            if (clsPersonDataLayer.getPersonByID(PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson getPersonByPhone(string Phone)
        {
            int PersonID = -1;
            string NationalNumber = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Address = string.Empty;
            string Email = string.Empty;
            int CountryID = 0;
            string ImagePath = string.Empty;

            if (clsPersonDataLayer.getPersonByPhone(ref PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson getPersonByNationalNumber(string NN)
        {
            int PersonID = -1;
            string NationalNumber = NN;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int CountryID = 0;
            string ImagePath = string.Empty;

            if (clsPersonDataLayer.getPersonByNationalNo(ref PersonID, NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool isExistsByID(int PersonID)
        {
            return clsPersonDataLayer.isPersonExistByID(PersonID);
        }

        private bool _addPerson()
        {
            this.PersonID = clsPersonDataLayer.addPerson(NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
            return this.PersonID > 0;
        }

        private bool _updatePerson()
        {
            return clsPersonDataLayer.updatePerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);

        }

        public static bool removePerson(int id)
        {
            if (isExistsByID(id))
            {
                return clsPersonDataLayer.deletePerson(id);
            }
            else return false;
        }

        public static DataTable getAllPeople()
        {
            return clsPersonDataLayer.getAllPeople();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    
                    if(_addPerson())
                    {
                        
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update: return _updatePerson();
            }
            return true;
        }

    }
}
