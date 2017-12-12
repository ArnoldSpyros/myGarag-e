using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_ConsumerMain : Form
    {

        public myGarage_ConsumerMain()
        {
            InitializeComponent();
            
        }

        public static bool appointmentmenuitemshown = false;

        private void newappointmentMenuStripItem_Click(object sender, EventArgs e)
        {
            if (!appointmentmenuitemshown)
            {
                myGarage_NewAppointment newappo = new myGarage_NewAppointment();
                newappo.Show();
                appointmentmenuitemshown = true;
            }
            else
            {
                MessageBox.Show("Έχετε ήδη ανοιχτό ένα ραντεβού!");
                myGarage_NewAppointment.ActiveForm.Focus();
            }
        }

        private void listappointmentMenuStripItem_Click(object sender, EventArgs e)
        {
            if (!appointmentmenuitemshown)
            {
                myGarage_AppointmentList newappo = new myGarage_AppointmentList();
                newappo.Show();
                appointmentmenuitemshown = true;
            }
            else
            {
                MessageBox.Show("Έχετε ήδη ανοιχτό ένα ραντεβού!");
                myGarage_NewAppointment.ActiveForm.Focus();
            }
        }
    }
}
