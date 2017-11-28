using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_NewItem : Form
    {
        public myGarage_NewItem()
        {
            InitializeComponent();
        }

        private void myGarage_NewItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGarage_ShopMain.newItemFormShown = false;
        }
    }
}
