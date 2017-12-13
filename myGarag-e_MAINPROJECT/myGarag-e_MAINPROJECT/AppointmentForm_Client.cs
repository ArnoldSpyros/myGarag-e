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
    public partial class AppointmentForm_Client : Form
    {
        public AppointmentForm_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Rantebou closed");
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            //Close the window and return to main window
            this.Close();
        }

        private void sendB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το αίτημα στάλθηκε!\nΣας υπενθυμίζουμε πως ο καταστηματάρχης πρέπει να επιβεβαιώσει το " +
                "ραντεβού και μέχρι τότε το αίτημα σας δεν θα οριστικοποιηθεί.", "Ραντεβού", MessageBoxButtons.OK);
            this.Close();
        }

        private void AppointmentForm_Client_Load(object sender, EventArgs e)
        {
            DataSet ds = DbFiles.DbMethods.getTableData("pelatis");
            d1.DataSource = ds.Tables["pelatis"];
        }
    }
}
