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
    public class LegendariesController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Legendaries
        public ActionResult Index()
        {
            return View(Legendary.GetInstance());
        }

        // GET: Legendaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Legendary legendary = db.Legendaries.Find(id);
            if (legendary == null)
            {
                return HttpNotFound();
            }
            return View(legendary);
        }

        // GET: Legendaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Legendaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RarityId")] Legendary legendary)
        {
            if (ModelState.IsValid)
            {
                db.Rarities.Add(legendary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(legendary);
        }

        // GET: Legendaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Legendary legendary = db.Legendaries.Find(id);
            if (legendary == null)
            {
                return HttpNotFound();
            }
            return View(legendary);
        }

        // POST: Legendaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RarityId")] Legendary legendary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(legendary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(legendary);
        }

        // GET: Legendaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Legendary legendary = db.Legendaries.Find(id);
            if (legendary == null)
            {
                return HttpNotFound();
            }
            return View(legendary);
        }

        // POST: Legendaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Legendary legendary = db.Legendaries.Find(id);
            db.Rarities.Remove(legendary);
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
