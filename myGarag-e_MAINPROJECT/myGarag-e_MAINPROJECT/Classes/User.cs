using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class User
    {
        private string ID;
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

        public User(string ID,RolosUser rolos, string username, string name, string lastName, string phoneNumber, string address)
        {
            this.ID = ID;
            this.roles[0] = rolos;
            this.username = username;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public String getRolosUser()
        {
            return this.roles[0].rolosname;
        }

        public String getUsername()
        {
            return this.username;
        }

        public String getName()
        {
            return this.name;
        }

        public String getLastname()
        {
            return this.lastName;
        }

        public String getPhonenumber()
        {
            return this.phoneNumber;
        }
    }
}
