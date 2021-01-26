using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class DataManifestacije
    {
        public static List<Manifestacija> ReadManifestationt(string path)
        {
            List<Manifestacija> manifestacije = new List<Manifestacija>();
            path = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);

            string line = "";
            List<Korisnik> korisnici = (List<Korisnik>)HttpContext.Current.Application["korisnici"];

            while((line = sr.ReadLine()) != null)
            {
                string[] token = line.Split(';');
                Prodavac prodavac;
                foreach(Korisnik k in korisnici)
                {
                    if (k.KorisnickoIme.Equals(token[12]))
                    {
                        prodavac = new Prodavac(k);
                        Manifestacija m = new Manifestacija(token[0], (TipManifestacije)Enum.Parse(typeof(TipManifestacije), token[1]), Int32.Parse(token[2]), DateTime.Parse(token[3]), Int32.Parse(token[4]), Int32.Parse(token[5]), Int32.Parse(token[6]), (StatusManifestacije)Enum.Parse(typeof(StatusManifestacije), token[7]), token[8], token[9], token[10], Int64.Parse(token[11]), prodavac, Int32.Parse(token[13]));
                        manifestacije.Add(m);
                    }
                }
            }

            sr.Close();
            stream.Close();

            return manifestacije;
        }


        public static void SaveManifestation(Manifestacija manifestacija)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/manifestacije.txt");
            FileStream stream = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(stream);

            sw.WriteLine(manifestacija.Naziv + ";" + manifestacija.TipManifestacije.ToString() + ";" + manifestacija.BrojMesta.ToString() + ";" + manifestacija.Vreme.ToString() + ";" + manifestacija.CenaRegular.ToString() + ";" + manifestacija.CenaFunPit.ToString() + ";" + manifestacija.CenaVIP.ToString() + ";" + manifestacija.Status.ToString() + ";" + manifestacija.Mesto.Ulica + ";" + manifestacija.Mesto.Broj + ";" + manifestacija.Mesto.Grad + ";" + manifestacija.Mesto.PostanskiBroj.ToString() + ";" + manifestacija.Prodavac.Korisnik.KorisnickoIme + ";" + manifestacija.PreostalaMesta.ToString());

            sw.Close();
            stream.Close();

        }
    }
}