using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class User
    {
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

        public User(RolosUser[] roles, string username, string name, string lastName, string phoneNumber, string address)
        {
            this.roles = roles;
            this.username = username;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }


    }
}
