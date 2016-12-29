using sklep.DAL;
using sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sklep.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria { NazwaKategorii = "asp.net mvc", NazwaPlikuIkony = "aspNetMvc.png", OpisKategorii = "opis" };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();
            return View();
            //nowy komentarz
            //pracujemy nad funkcjonalnoscia logowania
        }
    }
}