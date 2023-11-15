using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unos
{
    public class DAL
    {

        public static List<Korisnik> GetKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici.Add(new Korisnik("Igor", "123456", "Marković", new DateTime(2002, 12, 20)));
            korisnici.Add(new Korisnik("Marin", "Lozinka", "Budić", new DateTime(2002, 10, 28)));
            korisnici.Add(new Korisnik("David", "0000", "Soldatić", new DateTime(2002, 02, 20)));

            return korisnici;
        }
                    
            }
}
