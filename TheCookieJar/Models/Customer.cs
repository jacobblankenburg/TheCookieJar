using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int BoxPreference { get; set; }
        public int SubscriptionType { get; set; }
        public decimal BillingAmount { get; set; }
    }
}