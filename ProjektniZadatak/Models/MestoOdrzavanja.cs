using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class MestoOdrzavanja
    {
        private string ulica;
        private string broj;
        private string grad;
        private long postanskiBroj;

        public MestoOdrzavanja()
        {
        }

        public MestoOdrzavanja(string ulica, string broj, string grad, long postanskiBroj)
        {
            this.Ulica = ulica;
            this.Broj = broj;
            this.Grad = grad;
            this.PostanskiBroj = postanskiBroj;
        }

        public string Ulica { get => ulica; set => ulica = value; }
        public string Broj { get => broj; set => broj = value; }
        public string Grad { get => grad; set => grad = value; }
        public long PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }
    }
}