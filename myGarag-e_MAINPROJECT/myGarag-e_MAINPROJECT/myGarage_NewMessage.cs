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

        int messageID = 900;

        public myGarage_NewMessage()
        {
            InitializeComponent();
            DataSet dataset = DbMethods.getTableData("katastima");
            receiverCB.DataSource = dataset.Tables["katastima"];
            receiverCB.DisplayMember = "onomasiaKatastimatos";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMesageB_Click(object sender, EventArgs e)
        {
            string senderID = DbMethods.user.UserID; // message sender ID
            string receiverStore = receiverCB.Text; // receiver store name
            string messageContent = messageTB.Text; // message content
            DateTime timeSent = DateTime.Now; // time the message was sent
            string receiverID = ""; // message receiver ID (store owner)

            DataSet dataset = DbMethods.getTableData("katastima", "onomasiaKatastimatos", receiverStore);

            if (dataset.Tables["katastima"].Rows.Count > 0)
            {
                receiverID = dataset.Tables["katastima"].Rows[0][0].ToString(); // get the owner (receiverID) ID of the target store
                Minima minima = new Minima(senderID, receiverID, messageContent, timeSent); // instantiate a Minima object

                sendMessage(minima.Sender, minima.Receiver, minima.TimeSent, minima.Content); // call the sendMessage method to send the message
            }

        }


        private void sendMessage(string sender, string receiver, DateTime timeSent, string messageContent)
        {
            try
            {
                MySqlConnection dbConnection = DbMethods.setMySqlConnection(DbMethods.connectionString);
                string query = "INSERT INTO minimata (kodikosMinimatos,sender,receiver,date,message,seen) VALUES (@kodikosMinimatos,@sender,@receiver,@date,@message,@seen)";

                MySqlCommand command = new MySqlCommand(query, dbConnection);
                command.Parameters.AddWithValue("@kodikosMinimatos", messageID);
                command.Parameters.AddWithValue("@sender", sender);
                command.Parameters.AddWithValue("@receiver", receiver);
                command.Parameters.AddWithValue("@date", timeSent);
                command.Parameters.AddWithValue("@message", messageContent);
                command.Parameters.AddWithValue("@seen", 0);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery(); // exexute the SQL command and get the number of inserted rows
                dbConnection.Close();

                if (insertedRows > 0) // if message sent
                {
                    MessageBox.Show("Message sent!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messageID++;
                    this.Close();
                }

                else // if message not sent
                {
                    MessageBox.Show("Something went wrong", "Message not sent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException obj)
            {
                MessageBox.Show("Error sending the message!", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error); // error message
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

