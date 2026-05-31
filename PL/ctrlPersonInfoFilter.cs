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
    public partial class ctrlPersonInfoFilter : UserControl
    {
        public ctrlPersonInfoFilter()
        {
            InitializeComponent();

        }

        private void ctrlPersonInfoFilter_Load(object sender, EventArgs e)
        {
            ctrlFindPerson1.OnFindPerson += fillForm;

        }
        public int PersonID = -1;
        public void fillForm(int PersonID)
        {
            this.PersonID = PersonID;
            ctrlFindPerson1.fillWithPersonID(PersonID);
            ctrlPersonInfo1.FillForm(PersonID);
            

        }
    }

}
