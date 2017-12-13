using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_ConsumerMain : Form
    {

        public myGarage_ConsumerMain()
        {
            InitializeComponent();
            
        }

        private void νέοΡαντεβούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentForm_Client window = new AppointmentForm_Client();
            window.Visible = true;
        }
    }
}
