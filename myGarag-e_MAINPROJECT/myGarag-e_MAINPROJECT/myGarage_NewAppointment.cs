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
    public partial class myGarage_NewAppointment : Form
    {
        public myGarage_NewAppointment()
        {
            InitializeComponent();
        }

        private void NewAppointmentBtnOloklirwsi_Click(object sender, EventArgs e)
        {
            (this as Form).Close();
        }

        private void myGarage_NewAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewAppointmentTbOnomateponimo.Text != "" || NewAppointmentRTbSxolia.Text != "")
            {
                var msg = MessageBox.Show("Θέλετε να αποθηκεύσετε τις αλλαγές σας;", "Ειδοποίηση", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.OK)
                {
                    //Αποθηκεύει τις αλλαγές με κλήση μεθόδων της βάσης και κλείνει την φόρμα
                }
                else if (msg == DialogResult.Cancel)
                {
                    //ακυρώνει το close event γιατί ο χρήστης μπορεί να το έκανε καταλάθος
                    e.Cancel = true;
                }
                //στο No είναι σίγουρος ότι θέλει απλά να κλείσει την εφαρμογή
            }
        }

        private void myGarage_NewAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }
    }
}
