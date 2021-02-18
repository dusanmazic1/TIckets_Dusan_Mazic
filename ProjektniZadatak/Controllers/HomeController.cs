using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniZadatak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Manifestacija> manifestacije = (List<Manifestacija>)HttpContext.Application["manifestacije"];
            List<Manifestacija> sortiraneManifestacije = new List<Manifestacija>();

            sortiraneManifestacije = manifestacije.OrderBy(o => o.Vreme).ToList();
            sortiraneManifestacije.Reverse();

            return View(sortiraneManifestacije);
        }

    }
}