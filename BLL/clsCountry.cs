using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class clsCountry
    {
        public int ID;
        public string Name;
        public clsCountry(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public static DataTable getAllCountries()
        {
            return clsNationality.getAllCountriesNames();
        }

    }
}
