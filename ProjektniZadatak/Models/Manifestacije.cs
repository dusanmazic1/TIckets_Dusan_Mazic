using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class Manifestacije
    {
        static List<Manifestacija> manifestacije = (List<Manifestacija>)HttpContext.Current.Application["manifestacije"];

        public static List<Manifestacija> Update(Manifestacija manifestacija)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/manifestacije.txt");
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream);

            foreach(Manifestacija m in manifestacije)
            {
                sw.WriteLine(m.Naziv + ";" + m.TipManifestacije.ToString() + ";" + m.PreostalaMesta + ";" + m.Vreme.ToString() + ";" + m.CenaRegular.ToString() + ";" + m.CenaFunPit.ToString() + ";" + m.CenaVIP.ToString() + ";" + m.Status.ToString() + ";" + m.Mesto.Ulica + ";" + m.Mesto.Broj + ";" + m.Mesto.Grad + ";" + m.Mesto.PostanskiBroj.ToString() + ";" + m.Prodavac.Korisnik.KorisnickoIme + ";" + m.PreostalaMesta.ToString());
            }

            sw.Close();
            stream.Close();
        }
    }
}