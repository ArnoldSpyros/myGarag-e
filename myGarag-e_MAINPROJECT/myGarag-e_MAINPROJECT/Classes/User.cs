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
        private string userName;
        private string name;
        private string lname;
        private string phoneNumber;
        private string address;
        private int id;
        private Autokinito[] autokinita;

        User() { }
        public User(Minima[] minimata, RolosUser[] roles, string userName, string name, string lname, string phoneNumber, string address, int id, Autokinito[] autokinita)
        {
            this.minimata = minimata;
            this.roles = roles;
            this.userName = userName;
            this.name = name;
            this.lname = lname;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.id = id;
            this.autokinita = autokinita;
        }

        public Minima[] Minimata { get => minimata; set => minimata = value; }
        public RolosUser[] Roles { get => roles; set => roles = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Name { get => name; set => name = value; }
        public string Lname { get => lname; set => lname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public int Id { get => id; set => id = value; }
        public Autokinito[] Autokinita { get => autokinita; set => autokinita = value; }

       
        public Boolean isLoggedIn()
        {
            return true;
        }
        public Boolean login(string username,string pass)
        {
            return true;
        }

        public Boolean logout()
        {
            return true;
        }
        public int getNumberOfMessages()
        {
            return minimata.Count();
        }
        public void emptyMessageBox()
        {
           
        }
        public int getNumberOfCars()
        {
            return autokinita.Count();
        }
        public void removeCar(Autokinito autokinitoToDelete)
        {
            
        }

    }
}

   
