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
    public partial class myGarage_StartingPage : Form
    {
        public static myGarage_StartingPage stPage = new myGarage_StartingPage();
        public myGarage_StartingPage()
        {
            InitializeComponent();
        }

        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserTB.Text;
            string password = PassTB.Text;
            //DbFiles.DbMethods.findUser(username);
            //DbFiles.DbMethods.connectionString = "server=server=jabc.zapto.org;uid=" + username + ";pwd=" + password + ";database=adopse";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            myGarage_NewUser nUser = new myGarage_NewUser();
            nUser.Show();
            this.Visible = false;
        }
    }
}
