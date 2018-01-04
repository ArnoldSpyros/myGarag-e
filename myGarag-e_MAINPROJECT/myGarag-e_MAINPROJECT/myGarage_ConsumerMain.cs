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
            KatastasiUI.openThis(newappo);
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
            KatastasiUI.openThis(newappo);
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
            KatastasiUI.openThis(newuserinfo);
                //infoMenuItemShown = true;
            //}
        }

        private void σύνταξηΝέουΜηνύματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGarage_NewMessage form = new myGarage_NewMessage();
            KatastasiUI.openThis(form);
        }

        private void ConsumerMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //γινεται ερωτηση αν θελουμε να τερματισουμε την εφαρμογη, απο default γινεται cancel
        //στο ναι οντως θελουμε να την κλεισουμε
        //στο οχι θελουμε να κανουμε αποσυνδεση χρηστη
        //στο cancel ακυρωνουμε το event
        private void myGarage_ConsumerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGarage_genericTerminateOrLogoutForm newgentermform = new myGarage_genericTerminateOrLogoutForm();
            var diag = newgentermform.ShowDialog();
            if (diag == DialogResult.No)
            {
                DbFiles.DbMethods.user.logout();
                KatastasiUI.openStarting();
            }
            else if(diag == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                KatastasiUI.terminateProgram();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void εισερχόμεναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGarage_Inbox inbox = new myGarage_Inbox();
            KatastasiUI.openThis(inbox, true);
        }
    }
}
