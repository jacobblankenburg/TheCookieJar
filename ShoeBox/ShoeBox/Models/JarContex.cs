using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoeBox.Models
{
    public class JarContex : DbContext
    {
        public JarContex() : base("DefaultConnection")
        {
            
        }
        public DbSet<Jar> Jar { get; set; }

        public System.Data.Entity.DbSet<ShoeBox.Models.Beverage> Beverages { get; set; }
        public System.Data.Entity.DbSet<ShoeBox.Models.Cookie> Cookies { get; set; }
        public System.Data.Entity.DbSet<ShoeBox.Models.Mug> Mugs { get; set; }
        public System.Data.Entity.DbSet<ShoeBox.Models.CookieSurvey> Surveys { get; set; }
    }
}