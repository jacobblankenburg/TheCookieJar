using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class Jar
    {
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

<<<<<<< HEAD
=======
            public int Id { get; set; }
               

>>>>>>> 79e1b9073d2aa6d55b4156a7deac94afc7732d5f
    }
}