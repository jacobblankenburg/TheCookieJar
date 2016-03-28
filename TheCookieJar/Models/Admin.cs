using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class Admin
    { 
    public int ID { get; set; }
    public double? numberOfSuscribers { get; set; }
    
    public double? NumberOfKidAccounts { get; set; }
    public double? NumberOfTeaAccounts { get; set; }
        public double? NumberOfCoffeeAccounts { get; set; }
        public double? MonthlyRevenue { get; set; }
    public double? PercentKidAccounts { get; set; }
    public double? PercentTeaAccounts { get; set; }
        public double? PercentCoffeeAccounts { get; set; }

    }
}