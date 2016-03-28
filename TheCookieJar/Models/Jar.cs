using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class Jar
    {
            public int Id { get; set; }
            public string Beverage { get; set; }
            public string Cookie { get; set; }
            public decimal Price { get; set; }       
    }
}