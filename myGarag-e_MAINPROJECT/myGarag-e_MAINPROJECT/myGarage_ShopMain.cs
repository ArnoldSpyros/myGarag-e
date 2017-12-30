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

        private void diagrafiPelatiB_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουροι πως θέλετε να διαγράψετε τη συγκεκριμένη καταχώρηση; Αυτή η ενέργια δεν μπορεί να αναιρεθεί!","ΔΙΑΓΡΑΦΗ",MessageBoxButtons.YesNo);
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
