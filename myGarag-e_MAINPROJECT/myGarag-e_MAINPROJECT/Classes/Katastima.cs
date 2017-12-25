using System.Collections;
using System.ComponentModel;

namespace myGarag_e_MAINPROJECT.Classes
{
    public class Katastima
    {
        private string dieuthinsi;
        private int id;
        private string onomasia;
        private Katastimatarxis idioktitis;
        private string tilefono;
        private Proion[] proionta;
        private ArrayList av_Products=new ArrayList();

        public Katastima(){}

        public Katastima(string dieuthinsi, int id, string onomasia, Katastimatarxis idioktitis, string tilefono, Proion[] proionta, ArrayList av_Products)
        {
            this.dieuthinsi = dieuthinsi;
            this.id = id;
            this.onomasia = onomasia;
            this.idioktitis = idioktitis;
            this.tilefono = tilefono;
            this.proionta = proionta;
            this.av_Products = av_Products;
        }

        public string Dieuthinsi { get => dieuthinsi; set => dieuthinsi = value; }
        public int Id { get => id; set => id = value; }
        public string Onomasia { get => onomasia; set => onomasia = value; }
        public string Tilefono { get => tilefono; set => tilefono = value; }
        public ArrayList Av_Products { get => av_Products; set => av_Products = value; }
        internal Katastimatarxis Idioktitis { get => idioktitis; set => idioktitis = value; }
        internal Proion[] Proionta { get => proionta; set => proionta = value; }
    }
}