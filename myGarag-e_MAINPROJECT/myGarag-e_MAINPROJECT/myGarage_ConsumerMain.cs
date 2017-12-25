using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myGarag_e_MAINPROJECT.DbFiles;
using MySql.Data.MySqlClient;
using System.IO;
using myGarag_e_MAINPROJECT.Classes;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_ConsumerMain : Form
    {
        Proion selectedProion = new Proion();
        Pelatis tempPelatis = new Pelatis();

        int id = 0;
        public myGarage_ConsumerMain()
        {
            InitializeComponent();
            
        }
        MySqlConnection connection = new MySqlConnection("datasource=jabc.zapto.org;port=3306;Initial Catalog='adopse';username=TzRe;password=A6dT.R4e;");
        public MySqlConnection Connection { get => connection; set => connection = value; }
        
        private void myGarage_ConsumerMain_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        private void FillDGV(string SearchTextBox)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM proion WHERE CONCAT(kodikosProiontos, perigrafi, eikona, timi, kataskeuastis, xoraKataskeuis) LIKE '%" + SearchTextBox + "%'", Connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                 try
                 {
                      Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[2].Value;

                      MemoryStream ms = new MemoryStream(img);

                      selectedProion.Eikona = Image.FromStream(ms);

                      selectedProion.KodikosProiontos = (int)dataGridView1.CurrentRow.Cells[0].Value;
                      selectedProion.Perigrafi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                      selectedProion.Timi = (int)dataGridView1.CurrentRow.Cells[3].Value;
                      selectedProion.Kataskeuastis = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                      selectedProion.XoraKataskeuis = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                 }
                 catch (NullReferenceException) { }  
            }
            else
            {

            }
           
        }

        private void addtoCart_Click(object sender, EventArgs e)
        {        
            if (id == 0)
            {
                tempPelatis.addcart(selectedProion);
                cartCount.Text = String.Concat("", tempPelatis.num_product());
            }
            else
            {
                for(int i = 0; i < tempPelatis.Cart.Count; i++)
                {

                    MySqlCommand command = new MySqlCommand("INSERT INTO sinalagi(kodikosPelati, kodikosKatastimatarxi, kodikosProiontos, oloklirothike) VALUES (@kodikosPelati,@kodikosKatastimatarxi,@kodikosProiontos,@oloklirothike)", Connection);
                    command.Parameters.Add("@kodikosPelati", MySqlDbType.VarChar).Value = tempPelatis.getID();
                    command.Parameters.Add("@kodikosKatastimatarxi", MySqlDbType.VarChar).Value = Katastimatarxis.getID();
                    command.Parameters.Add("@kodikosProiontos", MySqlDbType.VarChar).Value = tempPelatis.Cart.ElementAt(i).KodikosProiontos;
                    command.Parameters.Add("@oloklirothike", MySqlDbType.VarChar).Value = 0;
    
                    ExecMyQuery(command, "Data Inserted");
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

            }
            
        }

        private void CartMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tempPelatis.Cart;
            id = 1;
            addtoCart.Text = "Αγορα";
            deleteFromCart.Visible = true;
            deleteFromCart.Enabled = true;
        }
        private void ProductsMenuItem_Click(object sender, EventArgs e)
        {
             FillDGV("");
             addtoCart.Text = "Προσθηκη στο καλαθι";
             deleteFromCart.Visible = false;
             deleteFromCart.Enabled = false;
             id = 0;
        }

        private void deleteFromCart_Click(object sender, EventArgs e)
        {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                cartCount.Text = tempPelatis.num_product().ToString();
        }
    }
}
