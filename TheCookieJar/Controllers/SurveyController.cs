using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TheCookieJar.Models;

namespace TheCookieJar.Controllers
{
    public class SurveyController : Controller
    {
        private JarContex db = new JarContex();

        private ApplicationDbContext adb = new ApplicationDbContext();


        // GET: Survey

        public ActionResult Index()
        {

            //commit: changed adminsController query functions

            return View(db.Surveys.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CookieSurvey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }
        public ActionResult Create()
        {
            return View();
        }


        // POST: Survey/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Question1,Question2,Question3,sum")] CookieSurvey survey)
        {
            if (ModelState.IsValid)
            {
                survey.TotalScore = survey.Question1 + survey.Question2 + survey.Question3;

                survey.userID = User.Identity.GetUserId();

                var hasUserAlreadyTakenSurvey = db.Surveys.FirstOrDefault(y => y.userID == survey.userID);

                if (hasUserAlreadyTakenSurvey != null)
                {
                    db.Surveys.RemoveRange(db.Surveys.Where(v => v.userID == survey.userID));
                    db.SaveChanges();
                }

                Jar TeaBox = new Jar();
                TeaBox.Name = "Tea Time";
                TeaBox.Price = 18.00;

                Jar CoffeeBox = new Jar();
                CoffeeBox.Name = "Coffee Box";
                CoffeeBox.Price = 18.00;

                Jar KidBox = new Jar();
                KidBox.Name = "Kid Box";
                KidBox.Price = 18.00;


                //survey.jar = survey.sum < 3 ? TeaBox : CoffeeBox;

                survey.isSubscribed = false;
                Random randNum = new Random();
                int rando = randNum.Next(2);

                if (survey.sum == 3)
                {
                    if (survey.Question1 == 1)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Tea"), new JarContent("ShortBread Cookie"), new JarContent("White Mug") };
                            survey.jar = TeaBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Green Tea"), new JarContent("Frosted Cookie"), new JarContent("Grey mug") };
                            survey.jar = TeaBox;
                        }
                    }
                    if (survey.Question1 == 2)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Coffee"), new JarContent("Dark Chocolate Cookie"), new JarContent("Black Mug") };
                            survey.jar = CoffeeBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Mocha"), new JarContent("Double Choclate chip Cookie"), new JarContent("Black mug") };
                            survey.jar = CoffeeBox;
                        }
                    }
                    if (survey.Question1 == 3)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Hot Chocolate"), new JarContent("M&M Cookie"), new JarContent("Green Mug") };
                            survey.jar = KidBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Latte"), new JarContent("SnowMan Cookie"), new JarContent("Blue mug") };
                            survey.jar = KidBox;
                        }
                    }

                }
                if (survey.sum >= 6)
                {
                    if (survey.Question2 == 1)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Tea"), new JarContent("ShortBread Cookie"), new JarContent("White Mug") };
                            survey.jar = TeaBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Green Tea"), new JarContent("Frosted Cookie"), new JarContent("Grey mug") };
                            survey.jar = TeaBox;
                        }
                    }
                    if (survey.Question2 == 2)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Coffee"), new JarContent("Dark Chocolate Cookie"), new JarContent("Black Mug") };
                            survey.jar = CoffeeBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Mocha"), new JarContent("Double Choclate chip Cookie"), new JarContent("Black mug") };
                            survey.jar = CoffeeBox;
                        }
                    }
                    if (survey.Question2 == 3)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Hot Chocolate"), new JarContent("M&M Cookie"), new JarContent("Green Mug") };
                            survey.jar = KidBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Latte"), new JarContent("SnowMan Cookie"), new JarContent("Blue mug") };
                            survey.jar = KidBox;
                        }
                    }

                }
                if (survey.sum == 9)
                {
                    if (survey.Question3 == 1)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Tea"), new JarContent("ShortBread Cookie"), new JarContent("White Mug") };
                            survey.jar = TeaBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Green Tea"), new JarContent("Frosted Cookie"), new JarContent("Grey mug") };
                            survey.jar = TeaBox;
                        }
                    }
                    if (survey.Question3 == 2)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Coffee"), new JarContent("Dark Chocolate Cookie"), new JarContent("Black Mug") };
                            survey.jar = CoffeeBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Mocha"), new JarContent("Double Choclate chip Cookie"), new JarContent("Black mug") };
                            survey.jar = CoffeeBox;
                        }
                    }
                    if (survey.Question3 == 3)
                    {
                        if (rando == 0)
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Hot Chocolate"), new JarContent("M&M Cookie"), new JarContent("Green Mug") };
                            survey.jar = KidBox;
                        }
                        else
                        {
                            TeaBox.JarContents = new List<JarContent>() { new JarContent("Latte"), new JarContent("SnowMan Cookie"), new JarContent("Blue mug") };
                            survey.jar = KidBox;
                        }
                    }

                }
                db.Surveys.Add(survey);
                db.SaveChanges();
                return Redirect("~/Survey/Index");
            }
            return View(survey);
        }

        // GET: Survey/Edit/5

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CookieSurvey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }


        // POST: Survey/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Question1,Question2,Question3,sum")] CookieSurvey survey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }


        // GET: Survey/Delete/5

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CookieSurvey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }


        // POST: Survey/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CookieSurvey survey = db.Surveys.Find(id);
            db.Surveys.Remove(survey);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}