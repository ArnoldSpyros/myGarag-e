using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class User
    {
        private string userID;
        private Minima[] minimata;
        private RolosUser[] roles = new RolosUser[2];
        private String username;
        private String name;
        private String lastName;
        private String phoneNumber;
        private String address;
        private Autokinito[] autokinita;

        public User()
        {
        }

        public User(string ID, RolosUser rolos, string username, string name, string lastName, string phoneNumber, string address)
        {
            this.userID = ID;
            this.roles[0] = rolos;
            this.roles[0].rolosname = "Pelatis";
            this.username = username;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }


        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string FirstRole
        {
            get { return roles[0].rolosname; }
            set { roles[0].rolosname = value; }
        }

        public string SecondRole
        {
            get { return roles[1].rolosname; }
            set { roles[1].rolosname = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phonenumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        //Επιστρέφει true αν έχει γεμίσει ο user του dbfiles που χρησιμοποιείται ευρέως
        //και είναι όντως ο ίδιος με αυτόν που εξετάζουμε
        public Boolean isLoggedIn()
        {
            return (DbFiles.DbMethods.user != null && DbFiles.DbMethods.user == this);
        }

        //Συνδέει τον χρήστη και δίνει feedback για το αν πέτυχε ή όχι
        public Boolean login(String username, String password)
        {
            return DbFiles.DbMethods.loginCustomer(username, password);
        }

        //αποσυνδέει τον χρήστη από το σύστημα
        public Boolean logout()
        {
            if (this.isLoggedIn())
            {
                DbFiles.DbMethods.user = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
