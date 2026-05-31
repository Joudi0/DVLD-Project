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
    public partial class frmAddUpdatePerson : Form
    {
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            ctrlAddUpdate1.getPersonByID(PersonID);
        }
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }


        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            ctrlAddUpdate1.OnCancelClick += _Close;
            ctrlAddUpdate1.OnAdd += Added;
        }

        public void getPersonByID(int PersonID)
        {
            ctrlAddUpdate1.getPersonByID(PersonID);
        }

        private void _Close()
        {
            this.Close();
        }
        public int PersonID = -1;
        public void Added(int personID)
        {
            this.PersonID = personID;
        }
    }
}
