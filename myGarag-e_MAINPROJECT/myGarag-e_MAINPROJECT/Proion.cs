using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace myGarag_e_MAINPROJECT
{
    class Proion
    {
        private int kodikosProiontos;
        private string perigrafi;
        private Image eikona;
        private int timi;
        private string kataskeuastis;
        private string xoraKataskeuis;

        public Proion()
        {
        }

        public Proion(int kodikosProiontos,string perigrafi,Image eikona,int timi,string kataskeuastis,string xoraKataskeuis)
        {
            this.kodikosProiontos = kodikosProiontos;
            this.perigrafi = perigrafi;
            this.eikona = eikona;
            this.timi = timi;
            this.kataskeuastis = kataskeuastis;
            this.xoraKataskeuis = xoraKataskeuis;
        }

        public int KodikosProiontos { get => kodikosProiontos; set => kodikosProiontos = value; }
        public string Perigrafi { get => perigrafi; set => perigrafi = value; }
        public Image Eikona { get => eikona; set => eikona = value; }
        public int Timi { get => timi; set => timi = value; }
        public string Kataskeuastis { get => kataskeuastis; set => kataskeuastis = value; }
        public string XoraKataskeuis { get => xoraKataskeuis; set => xoraKataskeuis = value; }


    }
}
