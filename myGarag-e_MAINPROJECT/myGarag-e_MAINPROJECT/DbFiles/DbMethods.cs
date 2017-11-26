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
            string dbCommand = String.Format("SELECT * FROM {0}", tableName);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();

            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

        }

        public static DataSet getTableData(string tableName, string conditionField, string condition) // it returns a datased which contains data from a table
        {
            MySqlConnection dbConnection = setMySqlConnection("server=localhost;uid=root;pwd=;database=adopse");
            string dbCommand = String.Format("SELECT * FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();

            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

        }


        public static bool deleteFromTable(string tableName, string conditionField, string condition)
        {
            bool deleted = false;
            MySqlConnection dbConnection = setMySqlConnection("server=localhost;uid=root;pwd=;database=adopse");
            string dbCommandStr = String.Format("DELETE FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
            MySqlCommand dbCommand = new MySqlCommand(dbCommandStr, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 0)
            {
                deleted = true;
            }

            dbConnection.Close();
            return deleted;

        }

    }
}
