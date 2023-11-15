using System;

namespace Unos
{
    public class Korisnik
    {

        private string username;
        private string password;
        private string name;
        private DateTime date = new DateTime();

        public Korisnik() { }
        public Korisnik(string username, string password, string name, DateTime date)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.date = date;
        }

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Date { get { return date; } set { date = value; } }


    }
}