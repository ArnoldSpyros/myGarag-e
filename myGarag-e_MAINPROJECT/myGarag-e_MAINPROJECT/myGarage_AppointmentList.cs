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

       

        private DataSet loadAppointmentList()
        {
            string sql = "SELECT R.ID,P.onoma,P.epitheto,P.kodikosPelati,R.description,R.Date,R.confirmed FROM Pelatis P JOIN Rantevou R " +
                "WHERE P.kodikosPelati=R.IDpelati AND P.kodikosPelati="+DbFiles.DbMethods.user.UserID;
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
