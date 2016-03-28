using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class JarContex : DbContext
    {
        public JarContex() : base("DefaultConnection")
        {

        }
        public DbSet<Box> Jar { get; set; }

        public System.Data.Entity.DbSet<TheCookieJar.Models.Beverage> Beverages { get; set; }
        public System.Data.Entity.DbSet<TheCookieJar.Models.Cookie> Cookies { get; set; }
        public System.Data.Entity.DbSet<TheCookieJar.Models.Mug> Mugs { get; set; }
        public System.Data.Entity.DbSet<TheCookieJar.Models.CookieSurvey> Surveys { get; set; }
    }
}