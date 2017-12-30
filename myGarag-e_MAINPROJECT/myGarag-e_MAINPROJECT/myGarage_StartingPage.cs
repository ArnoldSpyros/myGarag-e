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

        
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string username = UserTB.Text;
            string password = PassTB.Text;

            if (DbFiles.DbMethods.loginCustomer(username,password)) // if a user with the given username and passwrd was found
            {
                if (DbFiles.DbMethods.user.FirstRole.Equals("Pelatis"))
                {
                    myGarage_ConsumerMain nConsumer = new myGarage_ConsumerMain();
                    KatastasiUI.hideStarting();
                    KatastasiUI.openThis(nConsumer);
                }
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
    }
}
