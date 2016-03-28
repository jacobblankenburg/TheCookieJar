using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class JarContent
    {
        public JarContent(string name)
        {
            this.name = name;
        }

        public JarContent()
        {

        }
        public int ID { get; set; }
        public string name { get; set; }
    }
}
