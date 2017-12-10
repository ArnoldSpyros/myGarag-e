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
    public partial class myGarage_NewClient : Form
    {
        public myGarage_NewClient()
        {
            InitializeComponent();
        }

        private void myGarage_NewClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGarage_ShopMain.newClientFormShown = false;
        }



        private void registerClientB_Click(object sender, EventArgs e)
        {
            string ID = ClientTbKodikosPelati.Text;
            string name = ClientTbOnoma.Text;
            string lastName = ClientTbEpitheto.Text;
            string phoneNumber = ClientTbTilefono.Text;
            string password = ClientTbPassword.Text;

            int insertedRows = DbFiles.DbMethods.registUser(ID, name, lastName, phoneNumber, password);
            if (insertedRows != 0)
            {
                MessageBox.Show("Successfully registred!", "INFO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Could not register user!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
