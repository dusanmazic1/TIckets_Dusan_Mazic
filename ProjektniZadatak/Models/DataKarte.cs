using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class DataKarte
    {
        public static List<Karta> ReadKarte(string path)
        {
            List<Karta> karte = new List<Karta>();
            path = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);

            string line = "";

            while((line = sr.ReadLine())!= null)
            {
                string[] token = line.Split(';');
                Karta k = new Karta(token[0], token[1], Int32.Parse(token[2]), token[3], (StatusKarte)Enum.Parse(typeof(StatusKarte), token[4]), (TipKarte)Enum.Parse(typeof(TipKarte), token[5]));
                karte.Add(k);
            }

            sr.Close();
            stream.Close();

            return karte;
        }

        public static void SaveKarta(Karta k)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/karte.txt");
            FileStream stream = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(stream);

            sw.WriteLine(k.Id + ";" + k.Manifestacija.Naziv + ";" + k.Cena.ToString() + ";" + k.Kupac.Korinsik.KorisnickoIme + ";" + k.StatusKarte.ToString() + ";" + k.TipKarte.ToString());

            sw.Close();
            stream.Close();
        }
    }
}