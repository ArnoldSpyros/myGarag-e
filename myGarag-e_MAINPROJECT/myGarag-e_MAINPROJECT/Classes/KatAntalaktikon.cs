using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class KatAntalaktikon : Katastima
    {
        private Boolean isAgency;
        private Boolean acceptRantebou;

        public KatAntalaktikon()
        {
        }
        public KatAntalaktikon(bool isAgency, bool acceptRantebou)
        {
            this.isAgency = isAgency;
            this.acceptRantebou = acceptRantebou;
        }

        
    }
}
