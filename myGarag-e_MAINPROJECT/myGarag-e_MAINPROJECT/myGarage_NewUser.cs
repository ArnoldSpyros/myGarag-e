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
    public partial class myGarage_NewUser : Form
    {
        public myGarage_NewUser()
        {
            InitializeComponent();
        }

        private void myGarage_NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_StartingPage stPage = new myGarage_StartingPage();
            myGarage_StartingPage.stPage.Visible = true;
        }

        private void ClientBtnRegister_Click(object sender, EventArgs e)
        {
            //Αυτό το κουμπί κάνει καταχώρηση στοιχείων στη βάση για νέα εγγραφή χρήση.
            //Χρήστης γίνεται οποιοσδήποτε αλλά αν είναι καταστηματάρχης, πατήσει δηλαδή το checkbox,
            //Θα εμφανιστεί μια νέα φόρμα εισαγωγής του καταστήματος και αν είναι έγκυρη θα καταγραφεί
            //Το αν είναι έγκυρο το κατάστημα είναι ένα feature συσχέτισης με το όνομα στο google maps για μια δοθείσα περιοχή,
            //δηλαδή εκτός ορίων της σκοπιάς της εργασίας μας
            if (ClientChbKatastimatarxis.Checked)
            {
                groupBox2.Visible = true;
                groupBox2.Refresh();
                groupBox1.Hide();                
            }
            else
            {
                //Καλεί εγγραφή στοιχείων πελάτη, θεωρητικά πέτυχε και γυρνάμε στην αρχική φόρμα για login
                this.Close();
            }
        }

        private void katastimaBtnEisagogi_Click(object sender, EventArgs e)
        {
            //Κουμπί για τον καταστηματάρχη μόνο!
            //Καλεί εισαγωγή των στοιχείων καταστήματος στη βάση και επιστρέφει στην αρχική φόρμα για login,
            //Θεωρητικά πέτυχε η εγγραφή του καταστηματάρχη
            this.Close();
        }
    }
}
