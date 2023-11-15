using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Unos
{
    public class DatabaseHelper
    {
        private string GetConnectionString()
        {
            string connString = "Server=localhost;Database=vjezba;Uid=igor; Pwd=igor";

            return connString;
        }

        //public void GetDataFromDatabase()
        //{

        //    Korisnik korisnik = new Korisnik;

        //    string username = "Igor";
        //    var connection = new MySqlConnection(GetConnectionString());
        //    connection.Open();

        //    var command = new MySqlCommand("SELECT * from korisnici" +
        //                                                "WHERE korisnicko_ime= '" + username + "'", connection);
        //    var reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        korisnik.ID = reader.GetInt32("id");
        //        korisnik.ime = reader.GetString("ime");
        //        korisnik.prezime = reader.GetString("prezime");
        //        var test = reader.GetString("korisnicko ime");
        //    }
        //}


        public bool AutorizirajKorisnika(string korisnickoIme, string lozinka)
        {
            bool postoji = false;

            Korisnik korisnik = new Korisnik();
            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            var command = new MySqlCommand("SELECT ime_prezime from korisnici " +
                                            "WHERE korisnicko_ime ='" + korisnickoIme + 
                                            "' AND lozinka='" +  lozinka + 
                                            "' AND aktivan = 1" ,connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                postoji = reader.HasRows;
            } 
            
            // Provjeriti je li korisnik unio ispravne podatke i je li korisnik aktivan. 
            return postoji;
        }
    }

}
