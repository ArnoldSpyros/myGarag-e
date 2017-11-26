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

        public static string connectionString;

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
            MySqlConnection dbConnection = setMySqlConnection(connectionString);
            string dbCommand = String.Format("SELECT * FROM {0}", tableName);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();

            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

        }

        public static DataSet getTableData(string tableName, string conditionField, string condition) // it returns a datased which contains data from a table
        {
            MySqlConnection dbConnection = setMySqlConnection(connectionString);
            string dbCommand = String.Format("SELECT * FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
            DataSet dataset = new DataSet();

            dataAdapter.Fill(dataset, tableName);
            dbConnection.Close();
            return dataset;

        }


        public static int deleteFromTable(string tableName, string conditionField, string condition)
        {
            MySqlConnection dbConnection = setMySqlConnection(connectionString);
            string dbCommandStr = String.Format("DELETE FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
            MySqlCommand dbCommand = new MySqlCommand(dbCommandStr, dbConnection);

            int deletedRows = dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            return deletedRows; // return the number of deleted rows.
        }

    }
}
