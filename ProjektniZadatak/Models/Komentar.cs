using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Komentar
    {
        private Kupac kupac;
        private Manifestacija manifestacija;
        private string textKomentara;
        private int ocena;

        public Komentar()
        {
        }

        public Komentar(string imeKupca, string nazivManifestacije, string textKomentara, int ocena)
        {
            List<Kupac> kupci = (List<Kupac>)HttpContext.Current.Application["kupci"];
            List<Manifestacija> manifestacije = (List<Manifestacija>)HttpContext.Current.Application["manifestacije"];
            Kupac k = kupci.Find(u => u.Korinsik.KorisnickoIme.Equals(imeKupca));
            Manifestacija m = manifestacije.Find(u => u.Naziv.Equals(nazivManifestacije));

            Kupac = k;
            Manifestacija = m;
            this.TextKomentara = textKomentara;
            this.Ocena = ocena;
        }

        public Kupac Kupac { get => kupac; set => kupac = value; }
        public Manifestacija Manifestacija { get => manifestacija; set => manifestacija = value; }
        public string TextKomentara { get => textKomentara; set => textKomentara = value; }
        public int Ocena { get => ocena; set => ocena = value; }
    }
}