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

        protected MySqlConnection setMySqlConnection(string connectionString)
        {
            MySqlConnection dbConnection;

            try
            {
                dbConnection = new MySqlConnection(connectionString); // instatiating the connection
                dbConnection.Open();
            }

//#pragma warning disable CS0168 // The variable 'obj' is declared but never used
            catch (MySqlException obj)
//#pragma warning restore CS0168 // The variable 'obj' is declared but never used
            {
                MessageBox.Show("Σφάλμα σύνδεσης.\n" + obj.Message);
                return null;
            }

            return dbConnection;
        }


        private DataSet getTableData(string tableName) // it returns a datased which contains data from a table
        {
            MySqlConnection dbConnection = setMySqlConnection("server=localhost;uid=root;pwd=;database=adopse");
            string dbCommand = "SELECT * FROM " + tableName;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();


            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

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
                    ds = getTableData("pelatologio");
                    dataGridView2.DataSource = ds.Tables["pelatologio"];
                    break;

                case 2:
                    ds = getTableData("proion");
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
