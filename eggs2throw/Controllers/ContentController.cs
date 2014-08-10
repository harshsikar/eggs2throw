using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eggs2throw.Models;

namespace eggs2throw.Controllers
{
    public class ContentController : Controller
    {
        private eggs2throwEntities db = new eggs2throwEntities();

        //
        // GET: /Content/

        public ActionResult Index()
        {
            return View(db.movieProfiles.ToList());
        }

        //
        // GET: /Content/Details/5

        public ActionResult Details(int id = 0)
        {
            movieProfile movieprofile = db.movieProfiles.Find(id);
            if (movieprofile == null)
            {
                return HttpNotFound();
            }
            return View(movieprofile);
        }

        //
        // GET: /Content/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Content/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(movieProfile movieprofile)
        {
            movieprofile.upVote = 0;
            movieprofile.downVote = 0;
            if (ModelState.IsValid)
            {
                db.movieProfiles.Add(movieprofile);
                db.SaveChanges();
                return RedirectToAction("Index", "Home", null);
            }

            return View(movieprofile);
        }

        //
        // GET: /Content/Edit/5

        public ActionResult Edit(int id = 0)
        {
            movieProfile movieprofile = db.movieProfiles.Find(id);
            if (movieprofile == null)
            {
                return HttpNotFound();
            }
            return View(movieprofile);
        }

        //
        // POST: /Content/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(movieProfile movieprofile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieprofile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home", null);
            }
            return View(movieprofile);
        }

        //
        // GET: /Content/Delete/5

        public ActionResult Delete(int id = 0)
        {
            movieProfile movieprofile = db.movieProfiles.Find(id);
            if (movieprofile == null)
            {
                return HttpNotFound();
            }
            return View(movieprofile);
        }

        //
        // POST: /Content/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            movieProfile movieprofile = db.movieProfiles.Find(id);
            db.movieProfiles.Remove(movieprofile);
            db.SaveChanges();
            return RedirectToAction("Index", "Home", null);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}