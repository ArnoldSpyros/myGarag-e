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
            this.username = username;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }


        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public String FirstRole
        {
            get { return roles[0].rolosname; }
            set { roles[0].rolosname = value; }
        }

        public String SecondRole
        {
            get { return roles[1].rolosname; }
            set { roles[1].rolosname = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String Phonenumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
