using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class DataKomentari
    {
        public static List<Komentar> RedKometar(string path)
        {
            List<Komentar> komentari = new List<Komentar>();
            path = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);

            string line = "";
            List<Kupac> kupci = (List<Kupac>)HttpContext.Current.Application["kupci"];
            List<Manifestacija> manifestacije = (List<Manifestacija>)HttpContext.Current.Application["manifestacije"];
            while((line = sr.ReadLine())!= null)
            {
                string[] token = line.Split(';');
                Komentar kom = new Komentar(token[0], token[1], token[2], Int32.Parse(token[3]));

                komentari.Add(kom);
            }

            sr.Close();
            stream.Close();

            return komentari;
        }
        public static void SaveKomentar(Komentar k)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/komentari.txt");
            FileStream stream = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(stream);

            sw.WriteLine(k.Kupac.Korinsik.KorisnickoIme + ";" + k.Manifestacija.Naziv + ";" + k.TextKomentara + ";" + k.Ocena.ToString());

            sw.Close();
            stream.Close();
        }
    }
}