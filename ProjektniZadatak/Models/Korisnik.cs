using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Korisnik
    {
        private string korisnickoIme;
        private string lozinka;
        private string ime;
        private string prezime;
        private PolKorisnika pol;
        private DateTime datumRodjenja;
        private UlogaKorisnika uloga;

        public Korisnik()
        {
        }

        public Korisnik(string korisnickoIme, string lozinka, string ime, string prezime, PolKorisnika pol, DateTime datumRodjenja, UlogaKorisnika uloga)
        {
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.DatumRodjenja = datumRodjenja;
            this.Uloga = uloga;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public PolKorisnika Pol { get => pol; set => pol = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public UlogaKorisnika Uloga { get => uloga; set => uloga = value; }
    }
}