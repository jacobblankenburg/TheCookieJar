using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheCookieJar.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact The Cookie Jar.";

            return View();
        }
        public ActionResult BoxChoices()
        {
            ViewBag.Message = "View our boxes.";

            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
    }
}