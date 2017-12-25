using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class Sinergio : Katastima
    {
        private string typos;
        private string ipiresies;

        public Sinergio() { }
        public Sinergio(string typos, string ipiresies)
        {
            this.typos = typos;
            this.ipiresies = ipiresies;
        }
    }
}
