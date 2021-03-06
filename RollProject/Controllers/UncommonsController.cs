using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RollProject.Data;
using RollProject.Models;

namespace RollProject.Controllers
{
    public class UncommonsController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Uncommons
        public ActionResult Index()
        {
            return View(Uncommon.GetInstance());
        }

        // GET: Uncommons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uncommon uncommon = db.Uncommons.Find(id);
            if (uncommon == null)
            {
                return HttpNotFound();
            }
            return View(uncommon);
        }

        // GET: Uncommons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uncommons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RarityId")] Uncommon uncommon)
        {
            if (ModelState.IsValid)
            {
                db.Uncommons.Add(uncommon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uncommon);
        }

        // GET: Uncommons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uncommon uncommon = db.Uncommons.Find(id);
            if (uncommon == null)
            {
                return HttpNotFound();
            }
            return View(uncommon);
        }

        // POST: Uncommons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RarityId")] Uncommon uncommon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uncommon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uncommon);
        }

        // GET: Uncommons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uncommon uncommon = db.Uncommons.Find(id);
            if (uncommon == null)
            {
                return HttpNotFound();
            }
            return View(uncommon);
        }

        // POST: Uncommons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uncommon uncommon = db.Uncommons.Find(id);
            db.Rarities.Remove(uncommon);
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
