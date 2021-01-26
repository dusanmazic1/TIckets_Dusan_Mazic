using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProjektniZadatak.Models
{
    public class Kupci
    {
        static List<Kupac> kupci = (List<Kupac>)HttpContext.Current.Application["kupci"];

        public static void Update(Kupac kupac)
        {
            string path = HostingEnvironment.MapPath("~/App_Data/kupci.txt");
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream);

            foreach(Kupac k in kupci)
            {
                sw.WriteLine(k.Korinsik.KorisnickoIme + ";" + k.Bodovi.ToString() + ";" + k.TipKorisnika.Tip.ToString() + ";" + k.TipKorisnika.Popust.ToString() + ";" + k.TipKorisnika.PotrebniBrojBodova.ToString());
            }

            sw.Close();
            stream.Close();
        }
    }
}