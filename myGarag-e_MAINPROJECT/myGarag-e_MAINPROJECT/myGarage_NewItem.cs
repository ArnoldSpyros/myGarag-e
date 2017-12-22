using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT
{
    public partial class myGarage_NewItem : Form
    {
        public myGarage_NewItem()
        {
            InitializeComponent();
        }

        private void myGarage_NewItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGarage_ShopMain.newItemFormShown = false;
        }

        private void uploadProductImgB_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                productImgPB.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void insertProductB_Click(object sender, EventArgs e)
        {
            string productID = ItemTbKodikosProiontos.Text;
            string productName = ItemTbPerigrafi.Text;
            string productPrice = ItemTbTimi.Text;
            string productCompany = ItemTbKataskeuastis.Text;
            string productCountry = ItemTbXoraKataskeuis.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            productImgPB.Image.Save(ms, productImgPB.Image.RawFormat);
            byte[] img = ms.ToArray();

            int insertedRows = DbFiles.DbMethods.insertProduct(productID, productName, img, productPrice, productCompany, productCountry);
            MessageBox.Show("Inserted " + insertedRows + " products in the database", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
