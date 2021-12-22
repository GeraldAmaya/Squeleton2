using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Squeleton.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            int val1 = 0;
            int val2 = 2;
            int result = val1 + val2;

            ViewBag.Message = "Your application description page." + result;


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contacto de gato.";

            return View();
        }
    }
}