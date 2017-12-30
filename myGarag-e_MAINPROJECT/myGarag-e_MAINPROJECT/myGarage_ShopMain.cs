using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using myGarag_e_MAINPROJECT.Classes;


namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_ShopMain : Form
    {
        public myGarage_ShopMain()
        {
            InitializeComponent();
        }



        private void ShopManagementTabs_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                //MessageBox.Show("You are in the " + ShopManagementTabs.SelectedIndex + " tab"); // This line is for debug purpose. You can remove it if you want to.
                int idx = ShopManagementTabs.SelectedIndex;
                DataSet ds;

                switch (idx)
                {
                    case 0: //
                        break;

                    case 1:
                        //Κλήση της μεθόδου εμφάνισης πελατολόγιου
                        //
                        ds = loadPelatologio("1000");
                        dataGridView2.DataSource = ds.Tables["pelatologio"];
                        break;
                    case 2:
                        ds = DbFiles.DbMethods.getTableData("proion");
                        dataGridView3.DataSource = ds.Tables["proion"];
                        break;

                    case 3: //
                        break;

                    default: //
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet loadPelatologio(string kodikosKatastimatos)
        {
            try
            {
                //string sql = String.Format("SELECT * FROM {0}", "pelatologio");
                string sql = String.Format("SELECT PEL.kodikosSinalagis, PEL.kodikosPelati, P.onoma, P.epitheto, P.tilefono from pelatologio PEL JOIN pelatis P WHERE PEL.kodikosPelati = P.kodikosPelati AND PEL.kodikosPelatologiou = {0}", kodikosKatastimatos);
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);

                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

                adapter.Fill(ds, "pelatologio");
                con.Close();

                return ds;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }

        }

        //By default this is set to false, it's enabled when a new client form is shown and switches back and forth
        public static Boolean newClientFormShown = false;
        private void NewClientBtn_Click(object sender, EventArgs e)
        {

            if (newClientFormShown == false)
            {
                myGarage_NewUser newclientform = new myGarage_NewUser();
                newclientform.Show();
                newClientFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new clientele form is shown and switches back and forth
        public static Boolean newClienteleFormShown = false;
        private void NewClienteleBtn_Click(object sender, EventArgs e)
        {
            if (newClienteleFormShown == false)
            {
                myGarage_NewClientele newclienteleform = new myGarage_NewClientele();
                newclienteleform.Show();
                newClienteleFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new item form is shown and switches back and forth
        public static Boolean newItemFormShown = false;
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (newItemFormShown == false)
            {
                myGarage_NewItem newitemform = new myGarage_NewItem();
                newitemform.Show();
                newItemFormShown = true;
            }
        }

        //By defautl this is set to false, it's enabled when a new order form is shown and switches back and forth
        public static Boolean newOrderFormShown = false;
        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            myGarage_NewOrder neworderform = new myGarage_NewOrder();
            neworderform.Show();
            newOrderFormShown = true;
        }

        private void NewAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (!myGarage_ConsumerMain.appointmentmenuitemshown)
            {
                myGarage_NewAppointment newappo = new myGarage_NewAppointment();
                newappo.Show();
                myGarage_ConsumerMain.appointmentmenuitemshown = true;
            }
            else
            {
                MessageBox.Show("Έχετε ήδη ένα ραντεβού ανοιχτό!");
                myGarage_NewAppointment.ActiveForm.Focus();
            }

        }

        private void diagrafiPelatiB_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουροι πως θέλετε να διαγράψετε τη συγκεκριμένη καταχώρηση; Αυτή η ενέργια δεν μπορεί να αναιρεθεί!", "ΔΙΑΓΡΑΦΗ", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string code = dataGridView2.CurrentRow.Cells["kodikosSinalagis"].Value.ToString();

                if (diagrafiSinalagis(code) >= 1)
                {
                    MessageBox.Show("Η διαγραφή ολοκληρώθηκε!");
                    //Ανανέωση του πίνακα
                    DataSet ds = new DataSet();
                    ds = loadPelatologio("1000");
                    dataGridView2.DataSource = ds.Tables["pelatologio"];
                }
                else
                {
                    MessageBox.Show("Αποτυχία!");
                }
            }

        }

        private int diagrafiSinalagis(string kodikosSinalagis)
        {
            //Διαγραφή επιλεγμένου πελάτη
            try
            {
                string sql = "DELETE FROM pelatologio WHERE kodikosSinalagis = @kodikosSinalagis";
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);

                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@kodikosSinalagis", kodikosSinalagis);
                command.Prepare();

                int rowsAffected = command.ExecuteNonQuery();
                con.Close();

                return rowsAffected;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return 0;
            }
        }


        //NOT FINISHED!
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string senderName;
            //string senderLastName;
            //int rowIndex = 0; // dataGridView row index variable;

            //myGarage_Inbox form = new myGarage_Inbox(); // instantiating the myGarage_Inbox object

            //DataSet dataset = DbFiles.DbMethods.getTableData("minimata", "receiverID", "1000"); // MUST CHANGE to user.ID as the last parameter
            //DataTable datatable = dataset.Tables["minimata"];
            //DataColumn senderNameColumn = new DataColumn("Sender Name", typeof(string)); // instantiating a DataColumn to store and display the senderID's senderName in inbox's form dataGridView
            //DataColumn senderLastNameColumn = new DataColumn("Sender Last Name", typeof(string)); // instantiating a DataColumn to store and display the senderID's senderName in inbox's form dataGridView
            //datatable.Columns.Add(senderNameColumn);
            //datatable.Columns.Add(senderLastNameColumn);
            //form.inboxDGV.DataSource = dataset.Tables["minimata"];

            //Minima message = new Minima();
            
            //foreach (DataRow row in dataset.Tables["minimata"].Rows) // for each row in the table minimata
            //{
            //    string senderID = row[0].ToString(); // get the senderID's ID
            //    message.getSenderInfo(0, senderID, dataset); // call the getSenderInfo method of the message object to find senderID's first name and last name
            //    senderName = message.SenderName;
            //    senderLastName = message.SenderLastName;
            //    form.inboxDGV.Rows[rowIndex].Cells[5].Value = senderName; // set the 'Sender Name' column value of the current row to senderName variable value
            //    form.inboxDGV.Rows[rowIndex].Cells[6].Value = senderLastName; // set the 'Sender Last Name' column value of the current row to lastName variable value
            //    rowIndex++; // increase the row index by 1
            //}

            //form.inboxDGV.Columns[0].Visible = false; // set the senderID column visible propertie to false
            //form.inboxDGV.Columns[1].Visible = false; // set the receiverID column visible propertie to false
            //form.inboxDGV.Columns[5].DisplayIndex = 0; // set the senderID senderName column as the first column in the dataGridView
            //form.inboxDGV.Columns[6].DisplayIndex = 1; // set the senderID last senderName column as the second column in the dataGridView

            //form.Owner = this;
            //form.ShowDialog();
        }

        private void MessagesMenuItem_Click(object sender, EventArgs e)
        {
            myGarage_Inbox form = new myGarage_Inbox();
            form.ShowDialog();
        }
    }




}
