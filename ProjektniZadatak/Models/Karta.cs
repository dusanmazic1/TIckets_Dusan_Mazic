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

        public Karta()
        {

        }
    }
}