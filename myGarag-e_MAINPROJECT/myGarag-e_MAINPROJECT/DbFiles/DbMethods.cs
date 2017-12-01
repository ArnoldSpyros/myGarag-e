using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.Classes;

namespace myGarag_e_MAINPROJECT.DbFiles
{
    class DbMethods
    {

        public static string connectionString = "server=localhost;uid=root;pwd=;database=adopse";
        public static User user;

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

                MessageBox.Show("Connection error! \n" + obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static DataSet getTableData(string tableName, string conditionField, string condition) // it returns a datased which contains data from a table
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommand = String.Format("SELECT * FROM {0} WHERE {1} = '{2}'", tableName, conditionField, condition);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(dbCommand, dbConnection);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, tableName);
                dbConnection.Close();
                return dataset;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static int registUser(string ID, string name, string lastName, string phoneNumber, string password)
        {

            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string dbCommandStr = String.Format("INSERT INTO pelatis (kodikosPelati,onoma,epitheto,tilefono,password)" +
                    " VALUES (@ID,@name,@lastName,@phoneNumber,@password)");
                MySqlCommand dbCommand = new MySqlCommand(dbCommandStr, dbConnection);
                dbCommand.Parameters.AddWithValue("@ID", ID);
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
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }


        public static bool findCustomer(string username)
        {
            try
            {
                DataSet dataset = getTableData("pelatis", "username", username);
                DataRow tableRow = dataset.Tables["pelatis"].Rows[0];

                string ID = tableRow[0].ToString();
                string name = tableRow[1].ToString();
                string lastName = tableRow[2].ToString();
                string phoneNumber = tableRow[3].ToString();
                user = new User(ID,new Pelatis(), username, name, lastName, phoneNumber, "Unknown address");

                return true;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show("Error! Could not find customer \n" + obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


    }
}
