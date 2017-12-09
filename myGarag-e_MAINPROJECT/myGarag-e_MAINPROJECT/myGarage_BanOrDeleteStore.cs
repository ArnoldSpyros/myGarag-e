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
    public partial class myGarage_BanOrDeleteStore : Form
    {
        public myGarage_BanOrDeleteStore()
        {
            InitializeComponent();
        }

        private void myGarage_BanOrDeleteStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                myGarage_SystemAdminMain.bandeletebtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Refresh();
            DokimastikoLabel.Text = SystemAdminTbAnazitisi.Text;
        }
    }
}
