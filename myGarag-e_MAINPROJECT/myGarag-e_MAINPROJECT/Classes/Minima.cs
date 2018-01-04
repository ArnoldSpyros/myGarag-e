using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT.Classes
{
    class Minima
    {
        string senderID;
        string receiverID;
        string content;
        DateTime timeSent;
        string senderName;
        string senderLastName;
        string receiverName;
        string receiverLastName;

        public Minima()
        {

        }

        public Minima(string sender, string receiver, string content, DateTime timeSent)
        {
            this.senderID = sender;
            this.receiverID = receiver;
            this.content = content;
            this.timeSent = timeSent;
        }


        public string Sender
        {
            get { return senderID; }
            set { senderID = value; }
        }

        public string Receiver
        {
            get { return receiverID; }
            set { receiverID = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime TimeSent
        {
            get { return timeSent; }
            set { timeSent = value; }
        }

        public string SenderName
        {
            get { return senderName; }
            set { senderName = value; }
        }

        public string SenderLastName
        {
            get { return senderLastName; }
            set { senderLastName = value; }
        }

        public string ReceiverName
        {
            get { return receiverName; }
            set { receiverName = value; }
        }

        public string ReceiverLastName
        {
            get { return receiverLastName; }
            set { receiverLastName = value; }
        }



        public void getSenderInfo(int senderCategory, string senderID, DataSet dataset)
        {

            switch (senderCategory)
            {
                case 0: // if the senderID category is customer 'pelatis'
                    dataset = DbFiles.DbMethods.getTableData("pelatis", "kodikosPelati", senderID);
                    senderName = dataset.Tables["pelatis"].Rows[0][1].ToString(); // get the senderID's name
                    senderLastName = dataset.Tables["pelatis"].Rows[0][2].ToString(); // get the senderID's last name                                      
                    break;

                case 1: // if the senderID category is store owner (kastastimatarxis)
                    dataset = DbFiles.DbMethods.getTableData("katastimatarxis", "kodikosKatastimatarxi", senderID);
                    senderName = dataset.Tables["katastimatarxis"].Rows[0][1].ToString(); // get the senderID's name
                    senderLastName = dataset.Tables["katastimatarxis"].Rows[0][2].ToString(); // get the senderID's last name                                      
                    break;

                default: // if the given senderCategory code does not exist
                    MessageBox.Show("Could not find senderID details!", "No senderID found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }



        public void getReceiverInfo(int receiverCategory, string receiverID, DataSet dataset)
        {

            switch (receiverCategory)
            {
                case 0: // if the senderID category is customer 'pelatis'
                    dataset = DbFiles.DbMethods.getTableData("pelatis", "kodikosPelati", receiverID);
                    receiverName = dataset.Tables["pelatis"].Rows[0][1].ToString(); // get the senderID's name
                    receiverLastName = dataset.Tables["pelatis"].Rows[0][2].ToString(); // get the senderID's last name                                      
                    break;

                case 1: // if the senderID category is store owner (kastastimatarxis)
                    dataset = DbFiles.DbMethods.getTableData("katastimatarxis", "kodikosKatastimatarxi", receiverID);
                    receiverName = dataset.Tables["katastimatarxis"].Rows[0][1].ToString(); // get the senderID's name
                    receiverLastName = dataset.Tables["katastimatarxis"].Rows[0][2].ToString(); // get the senderID's last name                                      
                    break;

                default: // if the given senderCategory code does not exist
                    MessageBox.Show("Could not find senderID details!", "No senderID found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }





    }
}
