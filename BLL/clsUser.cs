using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        enum enMode { AddNew, Update }
        private enMode Mode;

        private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        public clsUser()
        {
            Mode = enMode.AddNew;
        }

        public static clsUser getUserByID(int UserID)
        {
            int PersonID = -1;
            string Username = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUsersDAL.getUserByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser getUserByUsername(string Username)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUsersDAL.getUserByUsername(ref UserID, ref PersonID, Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }


        public static clsUser Login(string u, string p)
        {
            int UserID = -1;
            int PersonID = -1;
            string Username = u;
            string Password = p;
            bool IsActive = false;

            if (clsUsersDAL.Login(ref UserID, ref PersonID, u, p, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool isExistsByID(int UserID)
        {
            return clsUsersDAL.isExistsByID(UserID);
        }

        public static bool isExistsByUsername(string Username)
        {
            return clsUsersDAL.isExistsByUsername(Username);
        }


        private bool _addUser()
        {

            this.UserID = clsUsersDAL.addUser(PersonID, Username, Password, IsActive);
            return this.UserID > 0;
        }

        private bool _updateUser()
        {
            return clsUsersDAL.updateUser(UserID, PersonID, Username, Password, IsActive);

        }

        public static bool removeUser(int id)
        {
            if(isExistsByID(id))
            {
                return clsUsersDAL.deleteUser(id);
            }
            else return false;
        }

        public static DataTable getAllUsers()
        {
            return clsUsersDAL.getAllUsers();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_addUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update: return _updateUser();
            }
            return true;
        }
    }
}
