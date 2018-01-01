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
            DialogResult res = MessageBox.Show("Είστε σίγουρος πως θέλετε να διαγράψετε το επιλεγμένο ραντεβού;", "Διαγραφή", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                try
                {
                    //Update table
                    string columnID = AppointmentListGridView.CurrentRow.Cells["ID"].Value.ToString();
                    int rows = deleteRantevou(columnID);
                    if (rows >= 1)
                    {
                        MessageBox.Show("Το ραντεβού διαγράφηκε!","Διαγραφή Ραντεβού",MessageBoxButtons.OK);
                        DataSet ds = DbFiles.DbMethods.getTableData("rantevou");
                        AppointmentListGridView.DataSource = ds.Tables["rantevou"];
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                
            }

        }

        private void myGarage_AppointmentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ConsumerMain.appointmentmenuitemshown = false;
        }

        private void myGarage_AppointmentList_Load(object sender, EventArgs e)
        {
            try
            {
                //Load table
                DataSet ds = loadAppointmentList();
                AppointmentListGridView.DataSource = ds.Tables["pelatis"];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void AppointmentBtnAnaneosi_Click(object sender, EventArgs e)
        {
            //Load table
            DataSet ds = loadAppointmentList();
            AppointmentListGridView.DataSource = ds.Tables["pelatis"];
        }

        private void AppointmentBtnEpibebaiosi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Είστε σίγουρος πως θέλετε να επιβεβαιώσετε το επιλεγμένο ραντεβού;", "Επιβεβαίωση", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                //Confirm rantevou
                //If already confirmed, show message

                if (AppointmentListGridView.CurrentRow.Cells["Confirmed"].Value.ToString() == "1")
                {
                    MessageBox.Show("Το ραντεβού έχει ήδη επιβεβαιωθεί! Δεν έγινε καμμία αλλαγή.","Επιβεβαίωση",MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string columnId = AppointmentListGridView.CurrentRow.Cells["ID"].Value.ToString();

                        int rows = confirmRantebou(columnId);
                        if (rows == 1)
                        {
                            MessageBox.Show("Το ραντεβού επιβεβαιώθηκε!","Επιτυχία!",MessageBoxButtons.OK);
                            DataSet ds = loadAppointmentList();
                            AppointmentListGridView.DataSource = ds.Tables["pelatis"];
                        }
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
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

        private DataSet loadAppointmentList()
        {
            string sql = "SELECT R.ID,P.onoma,P.epitheto,P.kodikosPelati,R.description,R.Date,R.confirmed FROM Pelatis P JOIN Rantevou R WHERE P.kodikosPelati=R.IDpelati AND P.kodikosPelati="+DbFiles.DbMethods.user.UserID;
            try
            {
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                adapter.Fill(ds, "pelatis");

                con.Close();
                return ds;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            
        }

    }
}
