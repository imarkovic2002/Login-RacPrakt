using System;
using System.Collections;
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
    public partial class Popis_korisnika : Form
    {

        List<Korisnik> lista = new List<Korisnik>();
        public Popis_korisnika()
        {
            InitializeComponent();
            lista = DAL.GetKorisnici();
            Refresh();
        }

        public void Refresh()
        {
            dgUsers.DataSource = new List<Korisnik>(lista);
            dgUsers.Refresh();
        }


        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NoviKorisnik noviKorisnik = new NoviKorisnik();
            noviKorisnik.ShowDialog();
            if (noviKorisnik.Korisnik != null)
            {
                lista.Add(noviKorisnik.Korisnik);
            }
            Refresh();
        }

        private void Popis_korisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
