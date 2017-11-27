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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //By defautl this is set to false, it's enabled when a new client form is shown and switches back and forth
        public static Boolean newClientFormShown = false;
        private void NewClientBtn_Click(object sender, EventArgs e)
        {
            
            if (newClientFormShown == false)
            {
                myGarage_NewClient newclientform = new myGarage_NewClient();
                newclientform.Show();
                newClientFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new clientele form is shown and switches back and forth
        public static Boolean newClienteleFormShown = false;
        private void NewClienteleBtn_Click(object sender, EventArgs e)
        {
            if (newClienteleFormShown == false)
            {
                myGarage_NewClientele newclienteleform = new myGarage_NewClientele();
                newclienteleform.Show();
                newClienteleFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new item form is shown and switches back and forth
        public static Boolean newItemFormShown = false;
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (newItemFormShown == false)
            {
                myGarage_NewItem newitemform = new myGarage_NewItem();
                newitemform.Show();
                newItemFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new order form is shown and switches back and forth
        public static Boolean newOrderFormShown = false;
        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            myGarage_NewOrder neworderform = new myGarage_NewOrder();
            neworderform.Show();
            newOrderFormShown = true;
        }
    }
}
