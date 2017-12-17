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
        public myGarage_NewAppointment()
        {
            InitializeComponent();
        }

        private void NewAppointmentBtnOloklirwsi_Click(object sender, EventArgs e)
        {
            //string name = NewAppointmentTbOnomateponimo.Text;
            string katastima = NewAppointmentSBKatastima.Text;
            
            string description = NewAppointmentRTbSxolia.Text;

            string kodikosKatastimatarxi = "";

            //βρες το ID του πελάτη
            

            //βρες το ID του καταστηματάρχη από το κατάστημα
            DataSet dsStoreID = DbFiles.DbMethods.getTableData("katastima", "odos", katastima);
            DataTable dt = dsStoreID.Tables["katastima"]; 
            foreach (DataRow dr in dt.Rows)
            {
                kodikosKatastimatarxi = dr["idioktitis"].ToString();
            }

            //Date και Time
            string datetime = "";
            string time = NewAppointmentChbDate.Value.ToString("HH':'mm':'00");
            string date = NewAppointmentChbDate.Value.ToString("yyyy'-'MM'-'dd");
            datetime += date + " " + time;

            //Insert method -> Needs ID, IDPelatis
            int rows = neoRantevou("", "", kodikosKatastimatarxi, description, datetime, "0");
            if (rows == 1)
            {
                MessageBox.Show("Η αίτηση ολοκληρώθηκε!");
            }
            (this as Form).Close();
            
        }

        public static int neoRantevou(string ID, string IDPelatis, string kodikosKatastimatarxi, string description, string datetime, string confirmed)
        {
            try
            {
                MySqlConnection dbConnection = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                string query = String.Format("INSERT INTO rantevou (ID,IDpelati,IDkatastimatarxi,Description,Date,Confirmed) VALUES (@ID,@IDPelati,@kodikosKatastimatarxi,@description,@date,@confirmed)"); // SQL query


                MySqlCommand command = new MySqlCommand(query, dbConnection);

                //Add parameters
                command.Parameters.AddWithValue("@ID", 10);
                command.Parameters.AddWithValue("@IDPelati", 100);
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

        private void myGarage_NewAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewAppointmentTbOnomateponimo.Text != "" || NewAppointmentRTbSxolia.Text != "")
            {
                var msg = MessageBox.Show("Θέλετε να αποθηκεύσετε τις αλλαγές σας;", "Ειδοποίηση", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.OK)
                {
                    //Αποθηκεύει τις αλλαγές με κλήση μεθόδων της βάσης και κλείνει την φόρμα
                }
                else if (msg == DialogResult.Cancel)
                {
                    //ακυρώνει το close event γιατί ο χρήστης μπορεί να το έκανε καταλάθος
                    e.Cancel = true;
                }
                //στο No είναι σίγουρος ότι θέλει απλά να κλείσει την εφαρμογή
            }
        }

        private void myGarage_NewAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }

        private void myGarage_NewAppointment_Load(object sender, EventArgs e)
        {
            //Φόρτωσε τα καταστήματα στο combobox
            DataSet ds = DbFiles.DbMethods.getTableData("katastima");
            NewAppointmentSBKatastima.DataSource = ds.Tables["katastima"];
            NewAppointmentSBKatastima.DisplayMember = "odos";

            //set Date Time picker to Time Format
            NewAppointmentChbDate.Format = DateTimePickerFormat.Time;
            
        }
    }
}
