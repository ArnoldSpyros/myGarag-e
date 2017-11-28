using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_ShopMain : Form
    {
        public myGarage_ShopMain()
        {
            InitializeComponent();
        }

       

        private void ShopManagementTabs_Selected(object sender, TabControlEventArgs e)
        {
            MessageBox.Show("You are in the " + ShopManagementTabs.SelectedIndex + " tab"); // This line is for debug purpose. You can remove it if you want to.
            int idx = ShopManagementTabs.SelectedIndex;
            DataSet ds;

            switch (idx)
            {
                case 0: //
                    break;

                case 1: 
                    ds = DbFiles.DbMethods.getTableData("pelatologio");
                    dataGridView2.DataSource = ds.Tables["pelatologio"];
                    break;

                case 2:
                    ds = DbFiles.DbMethods.getTableData("proion");
                    dataGridView3.DataSource = ds.Tables["proion"];
                    break;

                case 3: //
                    break;

                default: //
                    break;
            }

        }
    }
}
