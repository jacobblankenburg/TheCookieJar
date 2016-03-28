using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCookieJar.Models
{
    public class CookieSurvey
    {
        public int Id { get; set; }
        public int Question1 { get; set; }
        public int Question2 { get; set; }
        public int Question3 { get; set; }
        public int QuestionAnswer { get; set; }
        public int QuestionScore { get; set; }
        public int TotalScore { get; set; }
        public string userID { get; set; }
        public int sum { get; set; }
        public Jar jar { get; set; }
        public bool isSubscribed { get; set; }
    }
}