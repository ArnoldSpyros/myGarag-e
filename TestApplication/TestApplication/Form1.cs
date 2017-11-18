using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
        }

        private void message2L_Cick(object sender,EventArgs e)
        {
            if(message2L.Text != null)
            {
                MessageBox.Show("Hi again");
                mainB.Enabled = true;
            }
           
        }


        private void mainB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please remember to work on the same eproject!");
            mainB.Enabled = false;
            message1L.Text = "Hello world";
            message2L.Text = "Hello! It's your project manager Arnold. Click on this text!";
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
