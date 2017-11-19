using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace myGarag_e_MAINPROJECT.DbFiles
{
    class DbMethods
    {

        public static MySqlConnection setMySqlConnection(string connectionString)
        {
            MySqlConnection dbConnection;

            try
            {
                dbConnection = new MySqlConnection(connectionString); // instatiating the connection
                dbConnection.Open();
            }

            catch (MySqlException obj)
            {

                System.Windows.Forms.MessageBox.Show("Σφάλμα σύνδεσης.\n" + obj.Message);
                return null;
            }

            return dbConnection;
        }


        public static DataSet getTableData(string tableName) // it returns a datased which contains data from a table
        {
            MySqlConnection dbConnection = setMySqlConnection("server=localhost;uid=root;pwd=;database=adopse");
            string dbCommand = "SELECT * FROM " + tableName;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();


            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

        }
    }
}
