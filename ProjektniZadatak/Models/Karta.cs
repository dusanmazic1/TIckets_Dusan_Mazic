using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Karta
    {
        private string id;
        private Manifestacija manifestacija;
        private int cena;
        private Kupac kupac;
        private StatusKarte statusKarte;
        private TipKarte tipKarte;
        private bool pretraga;

        public Karta()
        {
        }
        public Karta(string id, string nazivManifestacije, int cenaKarte, string nazivKupca, StatusKarte statusKarte, TipKarte tipKarte)
        {
            List<Manifestacija> manifestacije = (List<Manifestacija>)HttpContext.Current.Application["manifestacije"];
            List<Kupac> kupci = (List<Kupac>)HttpContext.Current.Application["kupci"];
            Manifestacija manifestacija = manifestacije.Find(u => u.Naziv.Equals(nazivManifestacije));
            Kupac kupac = kupci.Find(u => u.Korinsik.KorisnickoIme.Equals(nazivKupca));

            this.Id = id;
            Manifestacija = manifestacija;
            this.cena = cenaKarte;
            Kupac = kupac;
            StatusKarte = statusKarte;
            TipKarte = tipKarte;
        }

        public string Id { get => id; set => id = value; }
        public Manifestacija Manifestacija { get => manifestacija; set => manifestacija = value; }
        public int Cena { get => cena; set => cena = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        public StatusKarte StatusKarte { get => statusKarte; set => statusKarte = value; }
        public TipKarte TipKarte { get => tipKarte; set => tipKarte = value; }
        public bool Pretraga { get => pretraga; set => pretraga = value; }
    }
}