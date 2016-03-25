using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheCookieJar.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        [ChildActionOnly]
        public ActionResult AdminMenu()
        {
            if (User.IsInRole("Admins")) // TODO: Remove magic string
            {
                return PartialView("Admin");
            }
            return new EmptyResult();
        }
    }
}