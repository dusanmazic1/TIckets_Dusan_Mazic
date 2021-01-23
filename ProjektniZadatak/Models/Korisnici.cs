using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class Korisnici
    {
        static List<Korisnik> korisnici = (List<Korisnik>)HttpContext.Current.Application["korisnici"];

        public static void Update(Korisnik korisnik)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/korisnici.txt");
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream);

            foreach(Korisnik k in korisnici)
            {
                sw.WriteLine(k.KorisnickoIme + ";" + k.Lozinka + ";" + k.Ime + ";" + k.Prezime + ";" + k.Pol.ToString() + ";" + k.DatumRodjenja.ToString() + ";" + k.Uloga.ToString());
            }

            sw.Close();
            stream.Close();
        }
    }
}