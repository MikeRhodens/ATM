using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
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
            ViewBag.Message = "send me shit";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(String message)
        {
            ViewBag.Message = "thanks";

            return View();
        }

        public ActionResult Foo(String Bar)
        {

            return Content(Bar);
        }
    }
}