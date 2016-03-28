using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheCookieJar.Models;

namespace TheCookieJar.Controllers
{
    public class AdminController : Controller
    {
        private Customer _db = new Customer();
        private ApplicationDbContext _adb = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            var model = new Admin
            {
                numberOfSuscribers = GetNumberOfSubscribers(),
                MonthlyRevenue = getMonthlyRevenue(),
                //percentHotChocolateAccounts =
                //    (db.Questions.Where(h => h.isSubscribed == true)
                //        .Where(a => a.Box.boxName == "Hot Chocolate Box")
                //        .Count()/getNumberOfSubscribers())*100,
                //percentTeaAccounts =
                //    (db.Questions.Where(b => b.isSubscribed == true).Where(n => n.Box.boxName == "Tea Box").Count()/
                //     getNumberOfSubscribers())*100,
                //percentCoffeeAccounts =
                //    (db.Questions.Where(b => b.isSubscribed == true).Where(n => n.Box.boxName == "Coffee Box").Count() /
                //     getNumberOfSubscribers()) * 100,
            };
            return View(model);
        }
        private decimal? getMonthlyRevenue()
        {
            decimal? monthlyRevenue = 0;
            monthlyRevenue = _adb.Customer.Select(x=>x.BillingAmount).Sum();
            return monthlyRevenue;
        }
        private double? GetNumberOfSubscribers()
        {
            double? numberOfSubsribers = 0;
            var isDatabaseEmpty = _adb.Customer.Select(y => y).FirstOrDefault();
            if (isDatabaseEmpty != null)
            {
                numberOfSubsribers = _adb.Customer.Count();
            }
            return numberOfSubsribers;
        }
        public ActionResult Admin()
        {
            throw new NotImplementedException();
        }
    }
}