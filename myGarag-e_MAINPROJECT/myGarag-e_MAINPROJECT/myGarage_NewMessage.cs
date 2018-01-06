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

            if (DbFiles.DbMethods.user.FirstRole.Equals("Pelatis")) // if the connected user is a client
            {
                DataSet storesDataset = DbMethods.getTableData("katastima");
                receiverInfoCB.DataSource = storesDataset.Tables["katastima"];
                receiverInfoCB.DisplayMember = "onomasiaKatastimatos";
            }
            else if (DbFiles.DbMethods.user.FirstRole.Equals("Katastimatarxis")) // ig the connected user is an owner
            {
                DataSet clienteleDataset = DbMethods.getTableData("pelatologio", "kodikosKatastimatarxi", DbMethods.user.UserID);
                DataSet customerDataset;
                string customerFullName;
                string customerFirstName;
                string customerLastName;

                foreach (DataRow row in clienteleDataset.Tables["pelatologio"].Rows) // for each row in the clientele
                {
                    string kodikos = row[1].ToString(); // get the customer's ID
                    customerDataset = DbMethods.getTableData("pelatis", "kodikosPelati", kodikos); // get customer's details
                    customerFirstName = customerDataset.Tables["pelatis"].Rows[0][1].ToString(); // get customer's first name
                    customerLastName = customerDataset.Tables["pelatis"].Rows[0][2].ToString(); // get customer's last name
                    customerFullName = customerFirstName + " " + customerLastName; // concatenate customer's first name and last name
                    receiverInfoCB.Items.Add(customerFullName); // add the cutomer inf to the receiver info combobox
                }

                receiverInfoCB.SelectedIndex = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMesageB_Click(object sender, EventArgs e)
        {
            string senderID = DbMethods.user.UserID;
            string receiverStore = receiverInfoCB.Text;
            string messageContent = messageTB.Text;
            DateTime timeSent = DateTime.Now;
            string receiverID = "";

            DataSet ds = DbMethods.getTableData("katastima", "onomasiaKatastimatos", receiverStore);

            DialogResult result = MessageBox.Show("Αποστολή του μηνύματος στο κατάστημα " + receiverStore + ";", "Αποστολή μηνύματος", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ds.Tables["katastima"].Rows.Count > 0)
                {
                    receiverID = ds.Tables["katastima"].Rows[0][0].ToString(); // get the owner (receiver) ID of the target store
                    Minima minima = new Minima(senderID, receiverID, messageContent, timeSent); // instantiate a Minima object

                    sendMessage(minima.Sender, minima.Receiver, minima.TimeSent, minima.Content); // call the sendMessage method to send the message
                }

            }
            else
            {
                MessageBox.Show("Η αποστολή του μηνύματος ακυρώθηκε", "Ακύρωση αποστολής", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Το μήνυμα εστάλει!", "Επιτυχής αποστολή", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (MySqlException obj)
            {
                MessageBox.Show("Σφάλμα αποστολής!", "Σφάλμα" + obj.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); // error message
            }


        }

    }
}
