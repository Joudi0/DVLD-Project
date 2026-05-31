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
    public partial class ctrlRetakeTestInfo : UserControl
    {
        public ctrlRetakeTestInfo()
        {
            InitializeComponent();
        }

        private void ctrlRetakeTestInfo_Load(object sender, EventArgs e)
        {
        }

        public void showPrice()
        {
            clsApplicationType appType = clsApplicationType.getApplicationTypeByID(7);
            if (appType != null)
            {
                if((int)appType.ApplicationFees == appType.ApplicationFees)
                {
                    lblAppFees.Text = ((int)appType.ApplicationFees).ToString() + "$";

                }
                else lblAppFees.Text = appType.ApplicationFees.ToString() + "$";
            } 
            else
            {
                lblAppFees.Text = "N/A";
                MessageBox.Show("Service ID 7 (Retake) not Found");
            }
        }
        public int CreateRetakeApplication(int personID)
        {
            clsApplication app = new clsApplication();
            clsApplicationType appType = clsApplicationType.getApplicationTypeByID(7);
            if (appType == null) MessageBox.Show("Service ID 7 (Retake) not Found");
            
            app.Person = clsPerson.getPersonByID(personID);
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = 7;
            app.PaidFees = appType.ApplicationFees;
            app.ApplicationStatus = 3; 
            app.LastStatusDate = DateTime.Now;
            app.CreatedByUserID = clsHelper.user.UserID;

            if (app.Save())
            {
                lblID.Text = app.ApplicationID.ToString();
                return app.ApplicationID;
            }
            return -1;
        }
    }
}
