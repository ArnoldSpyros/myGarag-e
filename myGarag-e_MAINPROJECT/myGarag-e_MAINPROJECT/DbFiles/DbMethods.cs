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

        public static string connectionString = "server=jabc.zapto.org;uid=BaKa;pwd=A6dB.K2a;database=adopse"; // database connection string.
        public static User user; // logged in user object.

        public static MySqlConnection setMySqlConnection(string connectionString) // method that sets the connection with the database.
        {
            MySqlConnection dbConnection;

            try
            {
                dbConnection = new MySqlConnection(connectionString); // instatiating the connection.
                dbConnection.Open();
            }
            catch (MySqlException obj)
            {

                MessageBox.Show("Connection error! \n" + obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // if there was an error then return null.
            }

            return dbConnection; // return the MySqlConnection object.
        }


        public static DataSet getTableData(string tableName) // it returns a datased which contains data from a table.
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database
                string query = String.Format("SELECT * FROM {0}", tableName); // SQL query
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbConnection);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, tableName);
                dbConnection.Close();
                return dataset; // return the dataset containg all data from the specified table.
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // if there was an error return null.
            }

        }

        public static DataSet getTableData(string tableName, string conditionField, string condition) // it returns a datased which contains data from a table
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database.
                string query = String.Format("SELECT * FROM {0} WHERE {1} = '{2}'", tableName, conditionField, condition); // SQL query.
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbConnection);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, tableName);
                dbConnection.Close();
                return dataset; // return the dataset containg data from the specified table.
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // if there was an error return null.
            }
        }

        public static int updateTable(string tableName, string columnToUpdate, string newValue, string conditionColumn, string condition)
        {

            MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database.

            //SQL query
            string query = String.Format("UPDATE {0} SET {1} = @newValue WHERE {2} = @condition", tableName, columnToUpdate, conditionColumn);
            MySqlCommand command = new MySqlCommand(query, dbConnection);

            try
            {
                // adding the parameters
                command.Parameters.AddWithValue("@newValue", newValue);
                command.Parameters.AddWithValue("@condition", condition);

                command.Prepare();
                int updatedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return updatedRows; // return number of updated rows
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // in case of error return 0 as the number of updated rows
            }

        }

        public static int deleteFromTable(string tableName, string conditionField, string condition)
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database.
                string query = String.Format("DELETE FROM {0} WHERE {1} = @condition", tableName, conditionField);
                MySqlCommand command = new MySqlCommand(query, dbConnection);

                command.Parameters.AddWithValue("@condition", condition);
                command.Prepare();
                int deletedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return deletedRows; // return the number of deleted rows.
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // in case of error return 0 as the number of deleted rows
            }
        }

        public static int registUser(string ID, string name, string lastName, string phoneNumber, string password)
        {

            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database.
                string dbCommandStr = String.Format("INSERT INTO pelatis (kodikosPelati,onoma,epitheto,tilefono,password)" +
                    " VALUES (@ID,@name,@lastName,@phoneNumber,@password)");
                MySqlCommand command = new MySqlCommand(dbCommandStr, dbConnection);

                // adding the parameters
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@password", password);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return insertedRows; // return number of inserted rows
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // in case of error return 0 as the number of inserted rows
            }

        }


        public static bool findCustomer(string username)
        {
            try
            {
                DataSet dataset = getTableData("pelatis", "username", username); // get clients data from the 'pelatis' table 
                DataRow tableRow = dataset.Tables["pelatis"].Rows[0]; // instantiate a DataRow object containing client's info

                string ID = tableRow[0].ToString(); // get client's ID
                string name = tableRow[1].ToString(); // get client's name
                string lastName = tableRow[2].ToString(); // get client's last  name
                string phoneNumber = tableRow[3].ToString(); // get client's phoneNumber
                user = new User(ID, new Pelatis(), username, name, lastName, phoneNumber, "Unknown address");

                return true; // found customer
            }
            catch (MySqlException obj)
            {
                MessageBox.Show("Error! Could not find customer \n" + obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // could not find customer
            }

        }

        public static int insertProduct(string kodikosProiontos, string perigrafi, byte[] eikona, string timi, string kataskeuastis, string xoraKataskeuis)
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString); // set connection with the database.
                string query = "INSERT INTO proion (kodikosProiontos,perigrafi,eikona,timi,kataskeuastis,xoraKataskeuis) VALUES (@kodikosProiontos,@perigrafi,@eikona,@timi,@kataskeuastis,@xoraKataskeuis)";
                MySqlCommand command = new MySqlCommand(query, dbConnection);

                // adding the parameters
                command.Parameters.AddWithValue("@kodikosProiontos", kodikosProiontos);
                command.Parameters.AddWithValue("@perigrafi", perigrafi);
                command.Parameters.AddWithValue("@eikona", eikona);
                command.Parameters.AddWithValue("@timi", timi);
                command.Parameters.AddWithValue("@kataskeuastis", kataskeuastis);
                command.Parameters.AddWithValue("@xoraKataskeuis", xoraKataskeuis);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return insertedRows; // return number of inserted rows.
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // in case of error return 0 as the number of inserted rows
            }
        }



    }
}
