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
    public partial class mygarage_UserInfo : Form
    {
        public mygarage_UserInfo()
        {
            InitializeComponent();
            fillrevertFunction();
        }

        bool toggleedit = false;

        //Εναλλάσσεται μεταξύ των δύο καταστάσεων για επεξεργασία των στοιχείων χρήστη
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle
            if (toggleedit == false)
            {
                UserInfoTbEpitheto.Enabled = true;
                UserInfoTbOnoma.Enabled = true;
                UserInfoTbPseudonumo.Enabled = true;
                UserInfoTbTilefono.Enabled = true;
                toggleedit = true;
            }
            else if (toggleedit == true)
            {
                questionFunction();
                UserInfoTbEpitheto.Enabled = false;
                UserInfoTbOnoma.Enabled = false;
                UserInfoTbPseudonumo.Enabled = false;
                UserInfoTbTilefono.Enabled = false;
                toggleedit = false;
            }
        }

        //Όταν η φόρμα κλείνει πρέπει να γυρίσει στην αρχική του κατάσταση η μεταβλητή infomenuitemshown.
        private void mygarage_UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myGarage_ConsumerMain.infoMenuItemShown = false;
        }

        //πρίν κλείσει η φόρμα κάνει έλεγχο των στοιχείων, αν έχουμε ανοιχτό το edit τότε ρωτάει για αποθήκευση
        private void mygarage_UserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toggleedit)
            {
                questionFunction(e);
            }
        }

        //απλή αποθήκευση
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFunction();
        }

        //ερώτηση για αποθήκευση, καλείται από τη φόρμα που κλείνει
        void questionFunction(FormClosingEventArgs e)
        {
            var msg = MessageBox.Show("Θέλετε να αποθηκεύσετε τις αλλαγές σας;", "Ειδοποίηση", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                //Αποθηκεύει τις αλλαγές με κλήση μεθόδων της βάσης και κλείνει την φόρμα
                saveFunction();
            }
            else if (msg == DialogResult.Cancel)
            {
                //ακυρώνει το close event γιατί ο χρήστης μπορεί να το έκανε καταλάθος
                e.Cancel = true;
            }
            //στο No είναι σίγουρος ότι θέλει απλά να κλείσει την εφαρμογή
        }

        //ερώτηση για αποθήκευση, καλείται οπουδήποτε
        void questionFunction()
        {
            var msg = MessageBox.Show("Θέλετε να αποθηκεύσετε τις αλλαγές σας;", "Ειδοποίηση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                //Αποθηκεύει τις αλλαγές με κλήση μεθόδων της βάσης και κλείνει την φόρμα
                saveFunction();
            }
            else
            {
                fillrevertFunction();
            }
            //στο No είναι σίγουρος ότι θέλει απλά να κλείσει την ερώτηση
        }

        //απλή αποθήκευση
        void saveFunction()
        {
            //αποθηκεύει τις αλλαγές που έχουν γίνει και συνεχίζει η εκτέλεση του προγράμματος
        }

        //εντολή γεμίσματος ή επαναφοράς στοιχείων χρήστη
        void fillrevertFunction()
        {
            //γέμισμα στοιχείων χρήστη κάθε φορά που ανοίγει την φόρμα
            try
            {
                UserInfoTbEpitheto.Text = DbFiles.DbMethods.user.Lastname;
                UserInfoTbOnoma.Text = DbFiles.DbMethods.user.Name;
                UserInfoTbPseudonumo.Text = DbFiles.DbMethods.user.Username;
                UserInfoTbTilefono.Text = DbFiles.DbMethods.user.Phonenumber;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
