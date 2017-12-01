using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myGarag_e_MAINPROJECT
{
    public partial class Display_Insert_Update_Delete_Search_Image_In_MySQL_Database : Form
    {
        public Display_Insert_Update_Delete_Search_Image_In_MySQL_Database()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=jabc.zapto.org;port=3306;Initial Catalog='adopse';username=TzRe;password=A6dT.R4e;");

        public MySqlConnection Connection { get => connection; set => connection = value; }

        private void Display_Insert_Update_Delete_Search_Image_In_MySQL_Database_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM pic WHERE CONCAT(idpic, Name, Description,Price,Constructor,Origin) LIKE '%" + valueToSearch + "%'", Connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BTN_CHOOSE_IMAGE_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[1].Value;

                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);

                labelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxDesc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxConstructor.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxOrigin.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (NullReferenceException) { }

        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO pic( Name, Description,Price,Constructor,Origin,img) VALUES (  @Name,@Description,@Price,@Constructor,@Origin,@img)", Connection);

            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@Description", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@Constructor", MySqlDbType.VarChar).Value = textBoxConstructor.Text;
            command.Parameters.Add("@Origin", MySqlDbType.VarChar).Value = textBoxOrigin.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted");

        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            Connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            Connection.Close();

            FillDGV("");
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE pic SET Name=@Name, Description=@Description,Price=@Price,Constructor=@Constructor,Origin=@Origin,img=@img WHERE idpic = @idpic", Connection);

            command.Parameters.Add("@idpic", MySqlDbType.VarChar).Value = labelID.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@Description", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@Constructor", MySqlDbType.VarChar).Value = textBoxConstructor.Text;
            command.Parameters.Add("@Origin", MySqlDbType.VarChar).Value = textBoxOrigin.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Updated");

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("DELETE FROM pic WHERE idpic = @idpic", Connection);

            command.Parameters.Add("@idpic", MySqlDbType.VarChar).Value = labelID.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            labelID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";
            textBoxConstructor.Text = "";
            textBoxOrigin.Text = "";

            pictureBox1.Image = null;

        }
    }

}
