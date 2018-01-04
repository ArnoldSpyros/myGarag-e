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
                        ds = loadPelatologio(DbFiles.DbMethods.user.UserID);
                        dataGridView2.DataSource = ds.Tables["pelatologio"];
                        break;
                    case 2:
                        ds = DbFiles.DbMethods.getTableData("proion");
                        dataGridView3.DataSource = ds.Tables["proion"];
                        break;

                    case 3:
                        ds = loadRantevou(DbFiles.DbMethods.user.UserID);
                        dataGridView4.DataSource = ds.Tables["rantevou"];
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

        

        //By default this is set to false, it's enabled when a new client form is shown and switches back and forth
        //public static Boolean newClientFormShown = false;
        private void NewClientBtn_Click(object sender, EventArgs e)
        {

            //if (newClientFormShown == false)
            //{
            myGarage_NewUser newclientform = new myGarage_NewUser();
            KatastasiUI.openThis(newclientform, true);
            //newClientFormShown = true;
            //}
        }

        //By defautl this is set to false, it's enabled when a new clientele form is shown and switches back and forth
        //public static Boolean newClienteleFormShown = false;
        private void NewClienteleBtn_Click(object sender, EventArgs e)
        {
            //if (newClienteleFormShown == false)
            //{
            myGarage_NewClientele newclienteleform = new myGarage_NewClientele();
            KatastasiUI.openThis(newclienteleform, true);
            //newClienteleFormShown = true;
            //}
        }

        //By defautl this is set to false, it's enabled when a new item form is shown and switches back and forth
        //public static Boolean newItemFormShown = false;
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            //if (newItemFormShown == false)
            //{
            myGarage_NewItem newitemform = new myGarage_NewItem();
            KatastasiUI.openThis(newitemform, true);
            //newItemFormShown = true;
            //}
        }

        //By defautl this is set to false, it's enabled when a new order form is shown and switches back and forth
        //public static Boolean newOrderFormShown = false;
        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            myGarage_NewOrder neworderform = new myGarage_NewOrder();
            KatastasiUI.openThis(neworderform, true);
            //newOrderFormShown = true;
        }

        private void NewAppointmentBtn_Click(object sender, EventArgs e)
        {
            //if (!myGarage_ConsumerMain.appointmentmenuitemshown)
            //{
            myGarage_NewAppointment newappo = new myGarage_NewAppointment();
            KatastasiUI.openThis(newappo, true);
            //myGarage_ConsumerMain.appointmentmenuitemshown = true;
            //}
            //else
            //{
            // MessageBox.Show("Έχετε ήδη ένα ραντεβού ανοιχτό!");
            //myGarage_NewAppointment.ActiveForm.Focus();
            //}

        }

        //STUFF FOR Pelatologio
        private void ananeosiB_Click(object sender, EventArgs e)//Pelatologio refresh
        {
            DataSet ds = new DataSet();
            ds = loadPelatologio(DbFiles.DbMethods.user.UserID);
            dataGridView2.DataSource = ds.Tables["pelatologio"];
        }

        private DataSet loadPelatologio(string kodikosKatastimatarxi)
        {
            try
            {
                string sql = String.Format("SELECT P.onoma, P.epitheto, P.tilefono, PEL.kodikosPelati, PEL.kodikosSinalagis FROM pelatologio PEL JOIN pelatis P WHERE PEL.kodikosPelati = P.kodikosPelati AND PEL.kodikosKatastimatarxi = {0}", kodikosKatastimatarxi);
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
        private void diagrafiPelatiB_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουροι πως θέλετε να διαγράψετε τη συγκεκριμένη καταχώρηση; Αυτή η ενέργεια δεν μπορεί να αναιρεθεί!", "ΔΙΑΓΡΑΦΗ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string code = dataGridView2.CurrentRow.Cells["kodikosSinalagis"].Value.ToString();

                    if (diagrafiSinalagis(code))
                    {
                        MessageBox.Show("Η διαγραφή ολοκληρώθηκε!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Ανανέωση του πίνακα
                        DataSet ds = new DataSet();
                        ds = loadPelatologio(DbFiles.DbMethods.user.UserID);
                        dataGridView2.DataSource = ds.Tables["pelatologio"];
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Αποτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool diagrafiSinalagis(string kodikosSinalagis)
        {
            //Διαγραφή επιλεγμένου πελάτη
            try
            {
                string sql = "DELETE FROM pelatologio WHERE kodikosSinalagis = @kodikosSinalagis";
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);

                MySqlCommand command = new MySqlCommand(sql, con);
                command.Parameters.AddWithValue("@kodikosSinalagis", kodikosSinalagis);
                command.Prepare();

                command.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        

        //FOR rantevou
        private DataSet loadRantevou(string kodikosKatastimatarxi)
        {
            try
            {
                string sql = String.Format("SELECT R.ID,P.onoma,P.epitheto,P.tilefono,P.kodikosPelati,R.description,R.date,R.confirmed FROM Rantevou R INNER JOIN Pelatis P WHERE R.IDpelati = P.kodikosPelati AND R.IDkatastimatarxi = {0}", kodikosKatastimatarxi);
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);

                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

                adapter.Fill(ds, "rantevou");
                con.Close();

                return ds;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Αποτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void AnaneosiBtn_Click(object sender, EventArgs e)//Rantevou refresh
        {
            DataSet ds = loadRantevou(DbFiles.DbMethods.user.UserID);
            dataGridView4.DataSource = ds.Tables["rantevou"];
        }

        private void confirmRantebouBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουρος πως θέλετε να επιβεβαιώσετε το επιλεγμένο ραντεβού;", "Επιβεβαίωση", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                //Confirm rantevou
                //If already confirmed, show message

                if (dataGridView4.CurrentRow.Cells["Confirmed"].Value.ToString() == "1")
                {
                    MessageBox.Show("Το ραντεβού έχει ήδη επιβεβαιωθεί! Δεν έγινε καμμία αλλαγή.", "Επιβεβαίωση", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string id = dataGridView4.CurrentRow.Cells["ID"].Value.ToString();

                        int rows = confirmRantebou(id);
                        if (rows == 1)
                        {
                            MessageBox.Show("Το ραντεβού επιβεβαιώθηκε!", "Επιτυχία!", MessageBoxButtons.OK);
                            DataSet ds = loadRantevou(DbFiles.DbMethods.user.UserID);
                            dataGridView4.DataSource = ds.Tables["rantevou"];
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                }
            }
        }

        private static int confirmRantebou(string id)
        {
            try
            {
                MySqlConnection connection = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                string mySql = "UPDATE rantevou SET Confirmed=1 WHERE ID=@columnID";

                MySqlCommand command = new MySqlCommand(mySql, connection);

                command.Parameters.AddWithValue("@columnID", id);
                command.Prepare();

                int affectedRows = command.ExecuteNonQuery();
                connection.Close();

                return affectedRows;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return 0;
            }
        }

        private void deleteRantevouBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουρος πως θέλετε να διαγράψετε το επιλεγμένο ραντεβού;", "Διαγραφή", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string columnID = dataGridView4.CurrentRow.Cells["ID"].Value.ToString();
                    int rows = deleteRantevou(columnID);
                    if (rows >= 1)
                    {
                        MessageBox.Show("Το ραντεβού διαγράφηκε!", "Διαγραφή Ραντεβού", MessageBoxButtons.OK);
                        //Update table
                        DataSet ds = loadRantevou(DbFiles.DbMethods.user.UserID);
                        dataGridView4.DataSource = ds.Tables["rantevou"];
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        }

        private static int deleteRantevou(string columnID)
        {
            try
            {
                MySqlConnection connection = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                string mySql = "DELETE FROM rantevou WHERE ID=@columnID";

                MySqlCommand command = new MySqlCommand(mySql, connection);

                command.Parameters.AddWithValue("@columnID", columnID);
                command.Prepare();

                int affectedRows = command.ExecuteNonQuery();
                connection.Close();

                return affectedRows;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return 0;
            }

        }


        private void myGarage_ShopMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGarage_genericTerminateOrLogoutForm newgentermform = new myGarage_genericTerminateOrLogoutForm();
            var diag = newgentermform.ShowDialog();
            if (diag == DialogResult.No)
            {
                DbFiles.DbMethods.user.logout();
                KatastasiUI.openStarting();
            }
            else if (diag == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                KatastasiUI.terminateProgram();
            }
        }
    }
}
