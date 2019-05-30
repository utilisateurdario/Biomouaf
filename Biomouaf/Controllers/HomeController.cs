using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biomouaf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Acceuil()
        {
            ViewBag.Message = "La page d'acceuil";

            return View();
        }
        public ActionResult Programmes()
        {
            ViewBag.Message = "Liste des programmes proposés";

            return View();
        }
        public ActionResult Coatching()
        {
            ViewBag.Message = "Si, Vous désirez un coatching, alors vous êtes au bon endroit";

            return View();
        }
        public ActionResult Temoignages()
        {
            ViewBag.Message = "Liste des témoignages Biomouaf";

            return View();
        }
        public ActionResult Aide()
        {
            ViewBag.Message = "Listes des questions généralement posées";

            return View();
        }
        public ActionResult Produits()
        {
            ViewBag.Message = "Liste des produits";

            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}