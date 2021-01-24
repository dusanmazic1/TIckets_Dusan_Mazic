using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Prodavac
    {
        private List<Manifestacija> manifestacije;
        private Korisnik korisnik;

        public Prodavac()
        {
        }

        public Prodavac(Korisnik korisnik)
        {
            this.Korisnik = korisnik;
            Manifestacije = new List<Manifestacija>();
        }

        public List<Manifestacija> Manifestacije { get => manifestacije; set => manifestacije = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
    }
}