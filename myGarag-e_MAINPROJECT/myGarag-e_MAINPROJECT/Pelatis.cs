using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT
{
    class Pelatis
    {
        private BindingList<Proion> cart = new BindingList<Proion>();
        private ArrayList rantebou = new ArrayList();

        
        public ArrayList Rantebou { get => rantebou; set => rantebou = value; }
        internal BindingList<Proion> Cart { get => cart; set => cart = value; }

        public Pelatis()
        {
        }


        public void addcart(Proion item)
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
