using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class DataKorisnik
    {
        public static List<Korisnik> ReadUser(string path)
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            path = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);

            string line = "";

            while((line = sr.ReadLine())!= null)
            {
                string[] token = line.Split(';');
                Korisnik k = new Korisnik(token[0], token[1], token[2], token[3], (PolKorisnika)Enum.Parse(typeof(PolKorisnika), token[4]), DateTime.Parse(token[5]), (UlogaKorisnika)Enum.Parse(typeof(UlogaKorisnika), token[6]));
                korisnici.Add(k);
                if(token[6] == "PRODAVAC")
                {

                }
            }
        }
    }
}