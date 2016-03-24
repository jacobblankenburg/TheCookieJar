using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeBox.Models
{
    public class CookieSurvey
    {

        public int ID { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string QuestionAnswer { get; set; }
        public int QuestionScore { get; set; }
        public int TotalScore { get; set; }


    }
}