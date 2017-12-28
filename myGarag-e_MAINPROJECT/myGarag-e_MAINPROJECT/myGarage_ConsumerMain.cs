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

        //public static bool appointmentmenuitemshown = false;

        private void newappointmentMenuStripItem_Click(object sender, EventArgs e)
        {
            //if (!appointmentmenuitemshown)
            //{
                myGarage_NewAppointment newappo = new myGarage_NewAppointment();
                newappo.ShowDialog();
                //appointmentmenuitemshown = true;
            //}
            //else
            //{
               // MessageBox.Show("Έχετε ήδη ανοιχτό ένα ραντεβού!");
                //myGarage_NewAppointment.ActiveForm.Focus();
            //}
        }

        private void listappointmentMenuStripItem_Click(object sender, EventArgs e)
        {
            //if (!appointmentmenuitemshown)
            //{
                myGarage_AppointmentList newappo = new myGarage_AppointmentList();
                newappo.ShowDialog();
                //appointmentmenuitemshown = true;
            //}
            //else
            //{
              //  MessageBox.Show("Έχετε ήδη ανοιχτό ένα ραντεβού!");
                //myGarage_NewAppointment.ActiveForm.Focus();
            //}
        }

        //public static bool infoMenuItemShown = false;

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!infoMenuItemShown)
            //{
                mygarage_UserInfo newuserinfo = new mygarage_UserInfo();
                newuserinfo.ShowDialog();
                newuserinfo.Focus();
                //infoMenuItemShown = true;
            //}
        }

        private void myGarage_ConsumerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //τερματισμός του προγράμματος
            myGarage_StartingPage.stPage.Close();
        }

        private void σύνταξηΝέουΜηνύματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGarage_NewMessage form = new myGarage_NewMessage();
            form.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConsumerMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
