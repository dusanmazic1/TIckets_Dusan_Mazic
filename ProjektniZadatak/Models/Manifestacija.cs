using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Manifestacija
    {
        private string naziv;
        private TipManifestacije tipManifestacije;
        private int brojMesta;
        private DateTime vreme;
        private int cenaRegular;
        private int cenaFunPit;
        private int cenaVIP;
        private StatusManifestacije status;
        private MestoOdrzavanja mesto;
        private Prodavac prodavac;
        private int preostalaMesta;

        public Manifestacija()
        {
        }

        public Manifestacija(string naziv, TipManifestacije tipManifestacije, int brojMesta, DateTime vreme, int cenaRegular, int cenaFunPit, int cenaVIP, StatusManifestacije status, string ulica, string broj, string grad, long postanskiBroj, Prodavac prodavac, int preostalaMesta)
        {
            MestoOdrzavanja mesto = new MestoOdrzavanja(ulica, broj, grad, postanskiBroj);

            this.Naziv = naziv;
            this.TipManifestacije = tipManifestacije;
            this.BrojMesta = brojMesta;
            this.Vreme = vreme;
            this.CenaRegular = cenaRegular;
            this.CenaFunPit = cenaFunPit;
            this.CenaVIP = cenaVIP;
            this.Status = status;
            this.Prodavac = prodavac;
            this.PreostalaMesta = preostalaMesta;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public TipManifestacije TipManifestacije { get => tipManifestacije; set => tipManifestacije = value; }
        public int BrojMesta { get => brojMesta; set => brojMesta = value; }
        public DateTime Vreme { get => vreme; set => vreme = value; }
        public int CenaRegular { get => cenaRegular; set => cenaRegular = value; }
        public int CenaFunPit { get => cenaFunPit; set => cenaFunPit = value; }
        public int CenaVIP { get => cenaVIP; set => cenaVIP = value; }
        public StatusManifestacije Status { get => status; set => status = value; }
        public MestoOdrzavanja Mesto { get => mesto; set => mesto = value; }
        public Prodavac Prodavac { get => prodavac; set => prodavac = value; }
        public int PreostalaMesta { get => preostalaMesta; set => preostalaMesta = value; }
    }
}