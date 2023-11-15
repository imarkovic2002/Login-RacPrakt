using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string password ="123456";
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            bool AutorizirajKorisnika;

            DatabaseHelper databaseHelper = new DatabaseHelper();

            AutorizirajKorisnika = databaseHelper.AutorizirajKorisnika(txtUsername.Text, txtPassword.Text);


            if (AutorizirajKorisnika)
            {
                Welcome welcome = new Welcome();
                welcome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Unijeli ste krivu lozinku.");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
