using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.Classes;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_NewAppointment : Form
    {
        //Variables to save text, store and datetime stuff
        private static string storeBackup = "", sxoliaBackup = "";

        public myGarage_NewAppointment()
        {
            InitializeComponent();
        }

        private void NewAppointmentBtnOloklirwsi_Click(object sender, EventArgs e)
        {
            string katastima = NewAppointmentSBKatastima.Text;

            string description = NewAppointmentRTbSxolia.Text;

            string kodikosKatastimatarxi = "";

            string pelatisID = "";

            try
            {
                //Generate a random ID -> WILL DELETE LATER
                Random rnd = new Random();
                string ID = rnd.Next(1000, 9999).ToString();

                //find pelatisID
                DataSet dsPelatisID = DbFiles.DbMethods.getTableData("pelatis", "username", DbFiles.DbMethods.user.Username);
                DataTable dtPelatis = dsPelatisID.Tables["pelatis"];

                foreach (DataRow dr in dtPelatis.Rows)
                {
                    if (dr["kodikosPelati"].ToString() != null)
                    {
                        pelatisID = dr["kodikosPelati"].ToString();
                    }
                }

                //find katastimatarxisID from Katastima
                DataSet dsStoreID = DbFiles.DbMethods.getTableData("katastima", "onomasiaKatastimatos", katastima);
                DataTable dt = dsStoreID.Tables["katastima"];
                foreach (DataRow dr in dt.Rows)
                {
                    kodikosKatastimatarxi = dr["idioktitis"].ToString();
                }

                //Date and Time
                string datetime = "";
                string time = NewAppointmentChbDate.Value.ToString("HH':'mm':'00");
                string date = NewAppointmentChbDate.Value.ToString("yyyy'-'MM'-'dd");
                datetime += date + " " + time;

                //Insert method
                int rows = neoRantevou(ID, pelatisID, kodikosKatastimatarxi, description, datetime, "0");
                if (rows == 1)
                {
                    MessageBox.Show("Η αίτηση ολοκληρώθηκε!", "Επιτυχία", MessageBoxButtons.OK);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }




        public static int neoRantevou(string ID, string IDPelatis, string kodikosKatastimatarxi, string description, string datetime, string confirmed)
        {
            try
            {
                MySqlConnection dbConnection = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                string query = String.Format("INSERT INTO rantevou (ID,IDpelati,IDkatastimatarxi,Description,Date,Confirmed) VALUES (@ID,@IDPelati,@kodikosKatastimatarxi,@description,@date,@confirmed)"); // SQL query


                MySqlCommand command = new MySqlCommand(query, dbConnection);

                //Add parameters
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@IDPelati", IDPelatis);
                command.Parameters.AddWithValue("@kodikosKatastimatarxi", kodikosKatastimatarxi);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@date", datetime);
                command.Parameters.AddWithValue("@confirmed", confirmed);

                command.Prepare();
                int insertedRows = command.ExecuteNonQuery();
                dbConnection.Close();
                return insertedRows;

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return 0;
            }
        }

        private void myGarage_NewAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }

        private void myGarage_NewAppointment_Load(object sender, EventArgs e)
        {
            //Load the shops in the combobox
            try
            {

                //DataSet ds = DbFiles.DbMethods.getTableData("katastima");
                //NewAppointmentSBKatastima.DataSource = ds.Tables["katastima"];
                //NewAppointmentSBKatastima.DisplayMember = "onomasiaKatastimatos";
                DataSet ds = KatastimataLoad();
                NewAppointmentSBKatastima.DataSource = ds.Tables["katastima"];
                NewAppointmentSBKatastima.DisplayMember = "onomasiaKatastimatos";

                //set Date Time picker to Time Format
                NewAppointmentChbDate.Format = DateTimePickerFormat.Time;

                //If the user saved his changes previously, load them into their respective controls
                if (sxoliaBackup != "")
                {
                    NewAppointmentRTbSxolia.Text = sxoliaBackup;
                }
                if (storeBackup != "")
                {
                    NewAppointmentSBKatastima.Text = storeBackup;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void myGarage_NewAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewAppointmentSBKatastima.Text != "" || NewAppointmentRTbSxolia.Text != "")
            {
                var msg = MessageBox.Show("Θέλετε να αποθηκεύσετε τις αλλαγές σας πριν κλείσει η φόρμα;", "Ειδοποίηση", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    //Save changes and shut down form
                    storeBackup = NewAppointmentSBKatastima.Text;
                    sxoliaBackup = NewAppointmentRTbSxolia.Text;
                    
                }
                else if(msg == DialogResult.No)
                {
                    //Quit without saving anything
                    
                }
                else if (msg == DialogResult.Cancel)
                {
                    //cancel close event
                    e.Cancel = true;
                }

            }
        }

        private DataSet KatastimataLoad()
        {
            try
            {
                string sql = "SELECT onomasiaKatastimatos FROM katastima WHERE meRantevou = 1";
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, con);
                DataSet dataset = new DataSet();

                dataAdapter.Fill(dataset, "katastima");
                con.Close();
                return dataset; // return the dataset containg all data from the specified table.

            }

            catch (Exception obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // if there was an error return null.
            }
        }
    }
}

