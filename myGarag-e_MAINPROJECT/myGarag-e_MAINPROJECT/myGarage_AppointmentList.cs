using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_AppointmentList : Form
    {
        public myGarage_AppointmentList()
        {
            InitializeComponent();
        }

        private void AppointmentBtnDiagrafi_Click(object sender, EventArgs e)
        {
            //Καλεί μια μέθοδο διαγραφής από το db files για να διαγράψει την επιλεγμένη γραμμή του grid view
        }

        private void myGarage_AppointmentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }
    }
}
