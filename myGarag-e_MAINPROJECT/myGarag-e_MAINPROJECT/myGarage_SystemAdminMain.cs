using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.Classes;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_SystemAdminMain : Form
    {
        public myGarage_SystemAdminMain()
        {
            InitializeComponent();
        }

        private void BanDeleteStoreBtn_Click(object sender, EventArgs e)
        {
            myGarage_BanOrDeleteStore fr = new myGarage_BanOrDeleteStore();
            fr.Show();
            fr.Focus();
            bandeletebtn = BanDeleteStoreBtn;
            bandeletebtn.Enabled = false;
        }
        public static Button bandeletebtn;

        private void myGarage_SystemAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGarage_genericTerminateOrLogoutForm newgentermform = new myGarage_genericTerminateOrLogoutForm();
            var diag = newgentermform.ShowDialog();
            if (diag == DialogResult.No)
            {
                DbFiles.DbMethods.user.logout();
                KatastasiUI.openStarting();
            }
            else if (diag == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                KatastasiUI.terminateProgram();
            }
        }
    }
}
