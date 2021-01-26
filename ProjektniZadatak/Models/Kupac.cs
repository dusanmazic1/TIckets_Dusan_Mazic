using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Kupac
    {
        private Korisnik korinsik;
        private List<Karta> karte;
        private int bodovi;
        private TipKorisnika tipKorisnika;

        public Kupac()
        {
        }

        public Kupac(Korisnik korinsik, int bodovi, ImeTipaKorisnika tipKupca, int popust, int potrebniBrojBodova)
        {
            this.Korinsik = korinsik;
            this.Bodovi = bodovi;
            TipKorisnika = new TipKorisnika(tipKupca, popust, potrebniBrojBodova);
            Karte = new List<Karta>();
        }

        public Korisnik Korinsik { get => korinsik; set => korinsik = value; }
        public List<Karta> Karte { get => karte; set => karte = value; }
        public int Bodovi { get => bodovi; set => bodovi = value; }
        public TipKorisnika TipKorisnika { get => tipKorisnika; set => tipKorisnika = value; }
    }
}