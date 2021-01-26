using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class Karte
    {
        static List<Karta> karte = (List<Karta>)HttpContext.Current.Application["karte.txt"];

        public static void Update(Karte karta)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/karte.txt");
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream);

            foreach(Karta k in karte)
            {
                sw.WriteLine(k.Id + ";" + k.Manifestacija.Naziv + ";" + k.Cena.ToString() + ";" + k.Kupac.Korinsik.KorisnickoIme + ";" + k.StatusKarte.ToString() + ";" + k.TipKarte.ToString());
            }

            sw.Close();
            stream.Close();
        }
    }
}