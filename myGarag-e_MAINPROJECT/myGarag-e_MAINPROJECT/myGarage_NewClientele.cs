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
using myGarag_e_MAINPROJECT.Classes;


namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_NewClientele : Form
    {
        public myGarage_NewClientele()
        {
            InitializeComponent();
        }

        private void myGarage_NewClientele_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ShopMain.newClienteleFormShown = false;
        }

        private void myGarage_NewClientele_Load(object sender, EventArgs e)
        {
            //Load the kodikosKatastimatarxi - is disabled always
            ClienteleTbKatID.Text = DbFiles.DbMethods.user.UserID;
            ClienteleTbKatID.Enabled = false;

            //Load the owner's shops by name
            DataSet ds;
            ds = DbFiles.DbMethods.getTableData("katastima", "idioktitis", DbFiles.DbMethods.user.UserID);
            ClienteleCbKatastima.DataSource = ds.Tables["katastima"];
            ClienteleCbKatastima.DisplayMember = "onomasiaKatastimatos";
        }

        private void ClienteleTbInsertB_Click(object sender, EventArgs e)
        {
            int kodikosPelatologiou, kodikosPelati, kodikosKatastimatarxi;

            //Check if fields are empty
            if (ClienteleTbKodikosPelati.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TryParsing each field before inserting it
                if (int.TryParse(ClienteleTbKodikosPelati.Text, out kodikosPelati))
                {
                    kodikosKatastimatarxi = int.Parse(ClienteleTbKatID.Text);

                    //Get kodikosPelatologiou
                    
                    kodikosPelatologiou = 0;
                    string name = ClienteleCbKatastima.Text;
                    DataSet ds;
                    ds = DbFiles.DbMethods.getTableData("katastima", "onomasiaKatastimatos", ClienteleCbKatastima.Text);
                    
                    foreach (DataRow dr in ds.Tables["katastima"].Rows)
                    {
                        kodikosPelatologiou = int.Parse(dr["kodikosKatastimatos"].ToString());
                    }
                    //Call the insert method
                    try
                    {
                        if (insertPelatologio(kodikosPelati, kodikosPelatologiou, kodikosKatastimatarxi) > 0)
                        {
                            MessageBox.Show("Η εισαγωγή ολοκληρώθηκε!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "ΣΦΑΛΜΑ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private int insertPelatologio (int kPelatis, int kPelatologio, int kKatastimatarxi)
        {
            //Generate a random number sinalagis
            Random r = new Random(100);
            int kSinalagis = r.Next(0, 10000);

            try
            {
                string sql = String.Format("INSERT INTO pelatologio VALUES ({0}, {1}, {2}, {3})", kPelatologio, kPelatis, kKatastimatarxi, kSinalagis);
                MySqlConnection con = DbFiles.DbMethods.setMySqlConnection(DbFiles.DbMethods.connectionString);

                MySqlCommand command = new MySqlCommand(sql, con);
                command.Prepare();
                int rows = command.ExecuteNonQuery();
                con.Close();
                return rows;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ΣΦΑΛΜΑ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

    }
}
