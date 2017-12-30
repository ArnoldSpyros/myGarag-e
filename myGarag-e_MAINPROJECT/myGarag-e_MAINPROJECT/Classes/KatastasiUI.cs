using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGarag_e_MAINPROJECT.Classes
{
    class KatastasiUI
    {
        //Ενημερώνεται καθ' όλη την διάρκεια τρεξίματος του προγράμματος και επικοινωνεί με τα στοιχεία
        //της εφαρμογής για να ελέγχονται διάφορες λειτουργίες όπως το αν έχουμε χρήστη μέσα
        //ή ποιά είναι η φόρμα εκκίνησης και η τρέχουσα φόρμα
        private static Boolean userLoggedIn;
        private static Form stPage;

        //αρχικοποιητής
        public static void Initialize(Boolean userin, Form start)
        {
            LoggedIn = userin;
            StartingPage = start;
        }

        static Form StartingPage
        {
            get { return stPage; }
            set { stPage = value; }
        }

        static Boolean LoggedIn
        {
            get { return userLoggedIn; }
            set { userLoggedIn = value; }
        }

        //κλείνει μια φόρμα που δεν χρειαζόμαστε
        //--------------------------------------
        public static void closeThis(Form fo)
        {
            try
            {
                fo.Close();
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------

        //ανοίγει μια φόρμα με δύο τρόπους, απαραίτητο να αρχικοποιηθεί αν δεν υπάρχει ήδη η φόρμα!!!
        //--------------------------------------
        public static void openThis(Form fo)
        {
            fo.Show();
            fo.Focus();
        }

        public static void openThis(Form fo, bool special)
        {
            if (special)
            {
                fo.ShowDialog();
            }
            else
            {
                fo.Show();
            }
            fo.Focus();
        }
        //--------------------------------------

        //μέθοδοι διαχείρησης της αρχικής σελίδας
        public static void openStarting()
        {
            StartingPage.Visible = true;
            StartingPage.Focus();
        }

        public static void hideStarting()
        {
            StartingPage.Visible = false;
        }

        public static void terminateProgram()
        {
            StartingPage.Close();
        }
        //--------------------------------------
    }
}
