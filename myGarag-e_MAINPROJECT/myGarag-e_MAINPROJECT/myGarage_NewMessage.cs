using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.DbFiles;
using myGarag_e_MAINPROJECT.Classes;
using MySql.Data.MySqlClient;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_NewMessage : Form
    {
        public myGarage_NewMessage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMesageB_Click(object sender, EventArgs e)
        {
            string senderID = DbMethods.user.UserID;
            string receiverStore = receiverTB.Text;
            string messageContent = messageTB.Text;
            DateTime timeSent = DateTime.Now;
            string receiverID = "";

            DataSet ds = DbMethods.getTableData("katastima", "onomasiaKatastimatos", receiverStore);

            if (ds.Tables["katastima"].Rows.Count > 0)
            {
                receiverID = ds.Tables["katastima"].Rows[0][0].ToString(); // get the owner (receiver) ID of the target store
                Minima minima = new Minima(senderID, receiverID, messageContent, timeSent); // instantiate a Minima object

                sendMessage(minima.Sender, minima.Receiver, minima.TimeSent, minima.Content); // call the sendMessage method to send the message
            }

        }


        private void sendMessage(string sender, string receiver, DateTime timeSent, string messageContent)
        {
            try
            {
                MySqlConnection dbConnection = DbMethods.setMySqlConnection(DbMethods.connectionString);
                string query = "INSERT INTO minimata (sender,receiver,date,message,seen) VALUES (@sender,@receiver,@date,@message,@seen)";

                MySqlCommand command = new MySqlCommand(query, dbConnection);
                command.Parameters.AddWithValue("@sender", sender);
                command.Parameters.AddWithValue("@receiver", receiver);
                command.Parameters.AddWithValue("@date", timeSent);
                command.Parameters.AddWithValue("@message", messageContent);
                command.Parameters.AddWithValue("@seen", 0);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                MessageBox.Show("Message sent!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // info message
                this.Close();
            }

            catch (MySqlException obj)
            {
                MessageBox.Show("Error sending the message!", "An error occurred:" + obj.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); // error message
            }


        }

    }
}
