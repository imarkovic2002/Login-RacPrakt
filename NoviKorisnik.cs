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
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
        }
        private Korisnik _korisnik;
            public Korisnik Korisnik
        {
            get { return _korisnik; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _korisnik = new Korisnik();
            _korisnik.Name = txtName.Text;
            _korisnik.Username = txtUsername2.Text;
            _korisnik.Password = txtPassword2.Text;
            _korisnik.Date = dtDate.Value;

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoviKorisnik_Load(object sender, EventArgs e)
        {

        }
    }
}
