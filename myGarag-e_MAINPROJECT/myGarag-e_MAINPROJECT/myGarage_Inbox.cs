using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.Classes;


namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_Inbox : Form
    {
        public myGarage_Inbox()
        {
            InitializeComponent();
        }


        private void inboxDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //MessageBox.Show("Worked sto keli 4!");
                string mess = inboxDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                KatastasiUI.openPopup(new myGarage_InboxMessagePopup(), mess);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int selectetItemIndex = 0;

            if (listView1.SelectedItems.Count > 0)
            {
                selectetItemIndex = listView1.FocusedItem.Index;
            }

            switch (selectetItemIndex)
            {
                case 0:
                    showInboxMessages();
                    break;

                case 1:
                    showSentMessages();
                    break;

                default:
                    break;
            }
        }


        private void showInboxMessages()
        {
            string senderName;
            string senderLastName;

            DataSet dataset = DbFiles.DbMethods.getTableData("minimata", "receiver", DbFiles.DbMethods.user.UserID); // MUST CHANGE to user.ID as the last parameter
            DataTable datatable = dataset.Tables["minimata"];
            DataColumn senderNameColumn = new DataColumn("Όνομα αποστολέα", typeof(string)); // instantiating a DataColumn to store and display the senderID's receiverName in inbox's form dataGridView
            DataColumn senderLastNameColumn = new DataColumn("Επώνυμο αποστολέα", typeof(string)); // instantiating a DataColumn to store and display the senderID's receiverName in inbox's form dataGridView
            datatable.Columns.Add(senderNameColumn);
            datatable.Columns.Add(senderLastNameColumn);
            inboxDGV.DataSource = dataset.Tables["minimata"];
            int i = 0;

            Minima message = new Minima();

            foreach (DataGridViewRow gridRow in inboxDGV.Rows)
            {
              //  foreach (DataRow row in dataset.Tables["minimata"].Rows) // for each row in the table minimata
              //  {
                    string senderID = dataset.Tables["minimata"].Rows[i++][1].ToString(); // get the senderID's ID

                    switch (DbFiles.DbMethods.user.FirstRole)
                    {
                        case "Pelatis": message.getSenderInfo(1, senderID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                            break;
                        case "Katastimatarxis": message.getSenderInfo(0, senderID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                            break;
                        default: break;
                    }

                    //message.getSenderInfo(0, senderID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                    senderName = message.SenderName;
                    senderLastName = message.SenderLastName;
                    gridRow.Cells[6].Value = senderName; // set the 'Sender Name' column value of the current row to receiverName variable value
                    gridRow.Cells[7].Value = senderLastName; // set the 'Sender Last Name' column value of the current row to lastName variable value
             //   }
            }

            inboxDGV.Columns[0].Visible = false; // set the messageID column visible prpertie to false
            inboxDGV.Columns[1].Visible = false; // set the senderID column visible propertie to false
            inboxDGV.Columns[2].Visible = false; // set the receiverID column visible propertie to false
            inboxDGV.Columns[6].DisplayIndex = 0; // set the senderID receiverName column as the first column in the dataGridView
            inboxDGV.Columns[7].DisplayIndex = 1; // set the senderID last receiverName column as the second column in the dataGridView
        }

        private void showSentMessages()
        {
            string receiverName;
            string receiverLastName;

            DataSet dataset = DbFiles.DbMethods.getTableData("minimata", "sender", DbFiles.DbMethods.user.UserID); // MUST CHANGE to user.ID as the last parameter
            DataTable datatable = dataset.Tables["minimata"];
            DataColumn receiverNameColumn = new DataColumn("Όνομα παραλήπτη", typeof(string)); // instantiating a DataColumn to store and display the senderID's receiverName in inbox's form dataGridView
            DataColumn receiverLastNameColumn = new DataColumn("Επώνυμο παραλήπτη", typeof(string)); // instantiating a DataColumn to store and display the senderID's receiverName in inbox's form dataGridView
            datatable.Columns.Add(receiverNameColumn);
            datatable.Columns.Add(receiverLastNameColumn);
            inboxDGV.DataSource = dataset.Tables["minimata"];
            int i =0;

            Minima message = new Minima();

            foreach (DataGridViewRow gridRow in inboxDGV.Rows)
            {
                //foreach (DataRow row in dataset.Tables["minimata"].Rows) // for each row in the table minimata
                //{
                    string receiverID = dataset.Tables["minimata"].Rows[i++][2].ToString(); // get the senderID's ID

                    switch (DbFiles.DbMethods.user.FirstRole)
                    {
                        case "Pelatis":
                            message.getReceiverInfo(1, receiverID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                            break;
                        case "Katastimatarxis":
                            message.getReceiverInfo(0, receiverID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                            break;
                        default: break;

                    }

                  //  message.getReceiverInfo(0, receiverID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
                    receiverName = message.ReceiverName;
                    receiverLastName = message.ReceiverLastName;
                    gridRow.Cells[6].Value = receiverName; // set the 'Sender Name' column value of the current row to receiverName variable value
                    gridRow.Cells[7].Value = receiverLastName; // set the 'Sender Last Name' column value of the current row to lastName variable value
              //  }
            }

            inboxDGV.Columns[0].Visible = false; // set the messageID column visible prpertie to false
            inboxDGV.Columns[1].Visible = false; // set the senderID column visible propertie to false
            inboxDGV.Columns[2].Visible = false; // set the receiverID column visible propertie to false
            inboxDGV.Columns[6].DisplayIndex = 0; // set the senderID receiverName column as the first column in the dataGridView
            inboxDGV.Columns[7].DisplayIndex = 1; // set the senderID last receiverName column as the second column in the dataGridView
        }


        private void deleteMessageB_Click(object sender, EventArgs e)
        {
            if (inboxDGV.SelectedRows.Count > 0) // if there are selected rows
            {
                string messageID = inboxDGV.SelectedRows[0].Cells[0].Value.ToString(); // get message ID

                DialogResult result = MessageBox.Show("Είστε σίγουρος για την διαγραφή?", "Ερώτηση", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK) // if the user pressed the OK button
                {
                    DbFiles.DbMethods.deleteFromTable("minimata", "kodikosMinimatos", messageID); // delete the message
                    MessageBox.Show("Το μήνυμα διαγράφτηκε επιτυχώς", "Διαγραφή", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // if the user cancel the message deletion
                {
                    MessageBox.Show("Η διαγραφή του μηνύματος ακυρώθηκε", "Ακύρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // NOT FINISHED
        private void answerMessageB_Click(object sender, EventArgs e)
        {
            if (inboxDGV.SelectedRows.Count > 0) // if there are selected rows
            {
                string messageID = inboxDGV.SelectedRows[0].Cells[1].Value.ToString(); // get the message ID
            }
        }


    }
}