using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjektniZadatak
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            List<Korisnik> korisnici = DataKorisnik.ReadUser("~/App_Data/korisnici.txt");
            HttpContext.Current.Application["korisnici"] = korisnici;

            List<Manifestacija> manifestacije = DataManifestacije.ReadManifestationt("~/App_Data/manifestacije.txt");
            HttpContext.Current.Application["manifestacije"] = manifestacije;

            List<Kupac> kupci = DataKupac.ReadKupac("~/App_Data/kupci.txt");
            HttpContext.Current.Application["kupci"] = kupci;

            List<Karta> karte = DataKarte.ReadKarte("~/App_Data/karte.txt");
            HttpContext.Current.Application["karte"] = karte;

            List<Komentar> komentari = DataKomentari.RedKometar("~/App_Data/komentari.txt");
            HttpContext.Current.Application["komentari"] = komentari;
        }
    }
}
