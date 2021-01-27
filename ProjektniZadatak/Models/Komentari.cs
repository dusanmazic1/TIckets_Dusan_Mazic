using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class Komentari
    {
        static List<Komentar> komentari = (List<Komentar>)HttpContext.Current.Application["komentari"];

        public static void UpdateKomnetar(Komentar komentar)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/komentari.txt");
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream);

            foreach(Komentar k in komentari)
            {
                sw.WriteLine(k.Kupac.Korinsik.KorisnickoIme + ";" + k.Manifestacija.Naziv + ";" + k.TextKomentara + ";" + k.Ocena.ToString());
            }

            sw.Close();
            stream.Close();
        }
    }
}