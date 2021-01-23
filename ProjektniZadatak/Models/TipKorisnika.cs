using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniZadatak.Models
{
    public class TipKorisnika
    {
        private ImeTipaKorisnika tip;
        private int popust;
        private int potrebniBrojBodova;

        public TipKorisnika()
        {
        }

        public TipKorisnika(ImeTipaKorisnika tip, int popust, int potrebniBrojBodova)
        {
            this.Tip = tip;
            this.Popust = popust;
            this.PotrebniBrojBodova = potrebniBrojBodova;
        }

        public ImeTipaKorisnika Tip { get => tip; set => tip = value; }
        public int Popust { get => popust; set => popust = value; }
        public int PotrebniBrojBodova { get => potrebniBrojBodova; set => potrebniBrojBodova = value; }
    }
}