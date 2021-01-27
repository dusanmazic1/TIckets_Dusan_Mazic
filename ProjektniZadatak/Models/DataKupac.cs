using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class DataKupac
    {
        public static List<Kupac> ReadKupac(string path)
        {
            List<Kupac> kupci = new List<Kupac>();
            path = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);

            string line = "";
            List<Korisnik> korisnici = (List<Korisnik>)HttpContext.Current.Application["korisnici"];

            while((line = sr.ReadLine())!= null)
            {
                Korisnik kor = new Korisnik();
                string[] token = line.Split(';');
                foreach(Korisnik k in korisnici)
                {
                    if (k.KorisnickoIme.Equals(token[0]))
                    {
                        kor = k;
                        break;
                    }
                }

                Kupac kup = new Kupac(kor, Int32.Parse(token[1]), (ImeTipaKorisnika)Enum.Parse(typeof(ImeTipaKorisnika), token[2]), Int32.Parse(token[3]), Int32.Parse(token[4]));
                kupci.Add(kup);
            }

            sr.Close();
            stream.Close();

            return kupci;
        }


        public static void UpdateKupci(Kupac k)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/kupci.txt");
            FileStream stream = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(stream);

            sw.WriteLine(k.Korinsik.KorisnickoIme + ";" + k.Bodovi.ToString() + ";" + k.TipKorisnika.Tip.ToString() + ";" + k.TipKorisnika.Popust.ToString() + ";" + k.TipKorisnika.PotrebniBrojBodova.ToString());

            sw.Close();
            stream.Close();
        }
    }
}