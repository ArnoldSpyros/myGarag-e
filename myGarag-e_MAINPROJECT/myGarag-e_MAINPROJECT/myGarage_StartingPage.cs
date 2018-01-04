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
    public partial class myGarage_StartingPage : Form
    {
        public myGarage_StartingPage()
        {
            InitializeComponent();
            KatastasiUI.Initialize(false, this);
        }

        //This is for the LoginCustomerBtn
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string username = UserTB.Text;
            string password = PassTB.Text;
            //DbFiles.DbMethods.user = new User();
            if (DbFiles.DbMethods.user.login(username, password)) // if a user with the given username and passwrd was found
            {
                //This is for the customer trying to login
                if (DbFiles.DbMethods.user.FirstRole.Equals("Pelatis"))
                {
                    myGarage_ConsumerMain nConsumer = new myGarage_ConsumerMain();
                    KatastasiUI.hideStarting();
                    KatastasiUI.openThis(nConsumer);
                }
                //This is for the Shopkeepers trying to login
                else if (DbFiles.DbMethods.user.FirstRole.Equals("Katastimatarxis"))
                {
                    myGarage_ShopMain nShop = new myGarage_ShopMain();
                    KatastasiUI.hideStarting();
                    KatastasiUI.openThis(nShop);
                }
            }
            //else if (DbFiles.DbMethods.findShopkeeper(username, password))
            //{
                
            //}
            else
            {
                startingPageErrLabel.Visible = true;
                loginTimer.Start(); 
            }

            //uncoment the line below to use the software as a user
            //DbFiles.DbMethods.connectionString = "server=jabc.zapto.org;uid=" + username + ";pwd=" + password + ";database=adopse";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            myGarage_NewUser nUser = new myGarage_NewUser();
            KatastasiUI.hideStarting();
            KatastasiUI.openThis(nUser);
        }

        private void myGarage_StartingPage_EnabledChanged(object sender, EventArgs e)
        {
                UserTB.Text = "";
                PassTB.Text = "";
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            startingPageErrLabel.Visible = false;
        }

        private void UserTB_Validating(object sender, CancelEventArgs e)
        {
            if (UserTB.Text.Equals(""))
            {
                userErrLabel.Text = "Το πεδίο δεν μπορεί να είναι κενό!";
                e.Cancel = true;
            }
        }

        private void UserTB_Validated(object sender, EventArgs e)
        {
            userErrLabel.Text = "";
        }

        private void PassTB_Validating(object sender, CancelEventArgs e)
        {
            if (PassTB.Text.Equals(""))
            {
                passErrLabel.Text = "Το πεδίο δεν μπορεί να είναι κενό!";
                e.Cancel = true;
            }
        }

        private void PassTB_Validated(object sender, EventArgs e)
        {
            passErrLabel.Text = "";
        }
    }
}
