using System;
namespace myGarag_e_MAINPROJECT.Classes
{
    public class Autokinito
    {
        private string license;
        private string brand;
        private string model;
        private string type_of_fuel;
        private string launch_age;
        private User owner;
        private DateTime last_service;

        public Autokinito() { }

        public Autokinito(string license, string brand, string model, string type_of_fuel, string launch_age, User owner, DateTime last_service)
        {
            this.license = license;
            this.brand = brand;
            this.model = model;
            this.type_of_fuel = type_of_fuel;
            this.launch_age = launch_age;
            this.owner = owner;
            this.last_service = last_service;
        }

        public string License { get => license; set => license = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Type_of_fuel { get => type_of_fuel; set => type_of_fuel = value; }
        public string Launch_age { get => launch_age; set => launch_age = value; }
        public DateTime Last_service { get => last_service; set => last_service = value; }
        internal User Owner { get => owner; set => owner = value; }


    }
}