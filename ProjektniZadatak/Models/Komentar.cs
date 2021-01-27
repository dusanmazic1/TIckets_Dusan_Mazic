using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Komentar
    {
        private Kupac imeKupca;
        private Manifestacija nazivManifestacije;
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

            ImeKupca = k;
            NazivManifestacije = m;
            this.TextKomentara = textKomentara;
            this.Ocena = ocena;
        }

        public Kupac ImeKupca { get => imeKupca; set => imeKupca = value; }
        public Manifestacija NazivManifestacije { get => nazivManifestacije; set => nazivManifestacije = value; }
        public string TextKomentara { get => textKomentara; set => textKomentara = value; }
        public int Ocena { get => ocena; set => ocena = value; }
    }
}