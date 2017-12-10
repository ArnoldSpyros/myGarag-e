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
                string query = String.Format("SELECT * FROM {0}", tableName);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbConnection);
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
                string query = String.Format("SELECT * FROM {0} WHERE {1} = '{2}'", tableName, conditionField, condition);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbConnection);
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

        public static int updateTable(string tableName, string columnToUpdate, string newValue, string conditionColumn, string condition)
        {

            MySqlConnection dbConnection = setMySqlConnection(connectionString);
            string query = String.Format("UPDATE {0} SET {1} = @newValue WHERE {2} = @condition", tableName, columnToUpdate, conditionColumn);
            MySqlCommand command = new MySqlCommand(query, dbConnection);

            try
            {
                command.Parameters.AddWithValue("@newValue", newValue);
                command.Parameters.AddWithValue("@condition", condition);

                command.Prepare();
                int result = command.ExecuteNonQuery();
                dbConnection.Close();
                return result;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public static int deleteFromTable(string tableName, string conditionField, string condition)
        {
            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
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
                MySqlCommand command = new MySqlCommand(dbCommandStr, dbConnection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@password", password);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
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
                user = new User(ID, new Pelatis(), username, name, lastName, phoneNumber, "Unknown address");

                return true;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show("Error! Could not find customer \n" + obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static int insertProduct(string kodikosProiontos, string perigrafi, byte[] eikona, string timi, string kataskeuastis, string xoraKataskeuis)
        {

            try
            {
                MySqlConnection dbConnection = setMySqlConnection(connectionString);
                string query = "INSERT INTO proion (kodikosProiontos,perigrafi,eikona,timi,kataskeuastis,xoraKataskeuis) VALUES (@kodikosProiontos,@perigrafi,@eikona,@timi,@kataskeuastis,@xoraKataskeuis)";
                MySqlCommand command = new MySqlCommand(query, dbConnection);

                command.Parameters.AddWithValue("@kodikosProiontos", kodikosProiontos);
                command.Parameters.AddWithValue("@perigrafi", perigrafi);
                command.Parameters.AddWithValue("@eikona", eikona);
                command.Parameters.AddWithValue("@timi", timi);
                command.Parameters.AddWithValue("@kataskeuastis", kataskeuastis);
                command.Parameters.AddWithValue("@xoraKataskeuis", xoraKataskeuis);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return insertedRows;
            }
            catch (MySqlException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }



    }
}
