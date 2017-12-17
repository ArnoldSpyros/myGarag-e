using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT
{
    class Pelatis
    {
        private ArrayList cart = new ArrayList();
        private ArrayList rantebou = new ArrayList();

        public void addcart(object item)
        {
            cart.Add(item);
        }

        public void empty()
        {
            cart.Clear();
        }

        public bool isEmpty()
        {
            if (cart.Count == 0)
            {
                return true;
            }
            else
                return false;
        }

        public void aithsiRantebou()
        {

        }

        public bool cancelRantebou()
        {
            return true;
        }
        public int num_product()
        {
            return cart.Count;
        }

        public int num_rant()
        {
            return 0;
        }
    }
}
