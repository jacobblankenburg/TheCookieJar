using System;
using System.Web.Mvc;

namespace TheCookieJar.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "Admin", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View(Admin());
        }
    }
}