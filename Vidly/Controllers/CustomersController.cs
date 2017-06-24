using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            ViewBag.customers = new List<Customers>()
            {
                new Customers{ Name = "Hesen"},
                new Customers{ Name = "Ismayil"},
                new Customers{ Name = "Vuqar"},
                new Customers{ Name = "Ilham"},
                new Customers{ Name = "Etibar"}

            };
            return View();
        }

        public ActionResult Customers(int id)
        {
            ViewBag.Customers = new List<Customers>()
            {
                new Customers{ Name = "Hesen"},
                new Customers{ Name = "Ismayil"},
                new Customers{ Name = "Vuqar"},
                new Customers{ Name = "Ilham"},
                new Customers{ Name = "Etibar"}

            };
            ViewBag.CustomerId = id;
            return View();
        }
    }
}