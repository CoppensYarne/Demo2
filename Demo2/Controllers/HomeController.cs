using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {

        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "Spinazie" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeienamiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente) && Array.IndexOf(groenten, zoekGroente) != -1)
            {
                ViewBag.Zoekresultaat = 
                $"De gezochte groente is de " +
                $"{Array.IndexOf(groenten, zoekGroente) + 1}" +
                $"e uit de lijst";
            }
            
            return View();
        }

    }
}