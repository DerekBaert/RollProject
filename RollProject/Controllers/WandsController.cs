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
    public class WandsController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Wands
        public ActionResult Index()
        {
            var items = db.Wands.Include(w => w.Rarity);
            return View(items.ToList());
        }

        // GET: Wands/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wand wand = db.Wands.Find(id);
            if (wand == null)
            {
                return HttpNotFound();
            }
            return View(wand);
        }

        // GET: Wands/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: Wands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] Wand wand)
        {
            if (ModelState.IsValid)
            {
                db.Wands.Add(wand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", wand.RarityId);
            return View(wand);
        }

        // GET: Wands/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wand wand = db.Wands.Find(id);
            if (wand == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", wand.RarityId);
            return View(wand);
        }

        // POST: Wands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] Wand wand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", wand.RarityId);
            return View(wand);
        }

        // GET: Wands/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wand wand = db.Wands.Find(id);
            if (wand == null)
            {
                return HttpNotFound();
            }
            return View(wand);
        }

        // POST: Wands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wand wand = db.Wands.Find(id);
            db.Wands.Remove(wand);
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
