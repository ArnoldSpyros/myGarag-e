using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT.DbFiles
{
    class DbMethods
    {

        public static string connectionString = "server=localhost;uid=root;pwd=;database=adopse";

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

                MessageBox.Show("Σφάλμα σύνδεσης.\n" + obj.Message);
                return null;
            }

            return dbConnection;
        }


        public static DataSet getTableData(string tableName) // it returns a datased which contains data from a table
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommand = String.Format("SELECT * FROM {0}", tableName);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, tableName);
                dbConnection.Close();
                return dataset;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static DataSet getTableData(string tableName, string conditionField, string condition) // it returns a datased which contains data from a table
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommand = String.Format("SELECT * FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, tableName);
                dbConnection.Close();
                return dataset;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message);
                return null;
            }
        }


        public static int deleteFromTable(string tableName, string conditionField, string condition)
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommandStr = String.Format("DELETE FROM {0} WHERE {1}={2}", tableName, conditionField, condition);
                MySqlCommand dbCommand = new MySqlCommand(dbCommandStr, dbConnection);

                int deletedRows = dbCommand.ExecuteNonQuery();
                dbConnection.Close();
                return deletedRows; // return the number of deleted rows.
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message);
                return 0;
            }
        }

        public static int registUser(string code, string name, string lastName, string phoneNumber, string password)
        {
            
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommandStr = String.Format("INSERT INTO pelatis (kodikosPelati,onoma,epitheto,tilefono,password)" +
                    " VALUES (@code,@name,@lastName,@phoneNumber,@password)");
                MySqlCommand dbCommand = new MySqlCommand(dbCommandStr, dbConnection);
                dbCommand.Parameters.AddWithValue("@code", code);
                dbCommand.Parameters.AddWithValue("@name", name);
                dbCommand.Parameters.AddWithValue("@lastName", lastName);
                dbCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                dbCommand.Parameters.AddWithValue("@password", password);
                int insertedRows = dbCommand.ExecuteNonQuery();

                dbConnection.Close();
                return insertedRows;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message);
                return 0;
            }


        }

    }
}
