using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class Lokacija
    {
        private double gografskaDuzina;
        private double gografskaSirina;
        private MestoOdrzavanja mestoOdrzavanja;

        public Lokacija(MestoOdrzavanja mestoOdrzavanja) 
        {
            var adress = mestoOdrzavanja.Ulica + " " + mestoOdrzavanja.Broj + ", " + mestoOdrzavanja.Grad + ", " + mestoOdrzavanja.PostanskiBroj;
            this.MestoOdrzavanja = mestoOdrzavanja;
        }

        public double GografskaDuzina { get => gografskaDuzina; set => gografskaDuzina = value; }
        public double GografskaSirina { get => gografskaSirina; set => gografskaSirina = value; }
        public MestoOdrzavanja MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }
    }
}