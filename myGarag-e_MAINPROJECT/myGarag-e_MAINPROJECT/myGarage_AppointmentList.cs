using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_AppointmentList : Form
    {
        public myGarage_AppointmentList()
        {
            InitializeComponent();
        }

        private void AppointmentBtnDiagrafi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουρος πως θέλετε να διαγράψετε το επιλεγμένο ραντεβού;", "Διαγραφή", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //Update πίνακα
                string columnID = AppointmentListGridView.CurrentRow.Cells["ID"].Value.ToString();
                int rows = deleteRantevou(columnID);
                if (rows >= 1)
                {
                    MessageBox.Show("Το ραντεβού διαγράφηκε!");
                    DataSet ds = DbFiles.DbMethods.getTableData("rantevou");
                    AppointmentListGridView.DataSource = ds.Tables["rantevou"];
                }
            }

        }

        private void myGarage_AppointmentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }

        private void myGarage_AppointmentList_Load(object sender, EventArgs e)
        {
            DataSet ds = DbFiles.DbMethods.getTableData("rantevou");
            AppointmentListGridView.DataSource = ds.Tables["rantevou"];
        }

        private void AppointmentBtnAnaneosi_Click(object sender, EventArgs e)
        {
            DataSet ds = DbFiles.DbMethods.getTableData("rantevou");
            AppointmentListGridView.DataSource = ds.Tables["rantevou"];
        }

        private void AppointmentBtnEpibebaiosi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είσται σίγουρος πως θέλετε να επιβεβαιώσετε το επιλεγμένο ραντεβού;", "Επιβεβαίωση", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //Επιβεβαίωση ραντεβού
                //Αν είναι ήδη επιβεβαιωμένο, γράψε μήνυμα

                if (AppointmentListGridView.CurrentRow.Cells["Confirmed"].Value.ToString() == "1")
                {
                    MessageBox.Show("Το ραντεβού έχει ήδη επιβεβαιωθεί! Δεν έγινε καμμία αλλαγή.");
                }
                else
                {
                    string columnId = AppointmentListGridView.CurrentRow.Cells["ID"].Value.ToString();

                    int rows = confirmRantebou(columnId);
                    if (rows == 1)
                    {
                        MessageBox.Show("Το ραντεβού επιβεβαιώθηκε!");
                        DataSet ds = DbFiles.DbMethods.getTableData("rantevou");
                        AppointmentListGridView.DataSource = ds.Tables["rantevou"];
                    }
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

        private static int confirmRantebou(string columnID)
        {
            try
            {
                MySqlConnection connection = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                string mySql = "UPDATE rantevou SET Confirmed=1 WHERE ID=@columnID";

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
        
    }
}
