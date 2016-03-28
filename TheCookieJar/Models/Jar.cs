using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class Jar
    {
<<<<<<< HEAD
        public int userId { get; set; }
        public string Name { get; set; }
        public string Beverage { get; set; }
        public string Cookie { get; set; }
        public string Mug { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
        public string jarName { get; set; }
        public double jarPrice { get; set; }
        public virtual List<JarContent> JarContents { get; set; }
=======
            public int Id { get; set; }
            public string Beverage { get; set; }
            public string Cookie { get; set; }
            public decimal Price { get; set; }       
>>>>>>> 6c250c0c1b652b5dc6c2f65d7f505acca0d25f85
    }
}