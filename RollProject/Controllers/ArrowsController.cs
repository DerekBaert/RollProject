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
    public class ArrowsController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Arrows
        public ActionResult Index()
        {
            var items = db.Arrows.Include(a => a.Rarity);
            return View(items.ToList());
        }

        // GET: Arrows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrow arrow = db.Arrows.Find(id);
            if (arrow == null)
            {
                return HttpNotFound();
            }
            return View(arrow);
        }

        // GET: Arrows/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: Arrows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] Arrow arrow)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(arrow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", arrow.RarityId);
            return View(arrow);
        }

        // GET: Arrows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrow arrow = db.Arrows.Find(id);
            if (arrow == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", arrow.RarityId);
            return View(arrow);
        }

        // POST: Arrows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] Arrow arrow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arrow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", arrow.RarityId);
            return View(arrow);
        }

        // GET: Arrows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrow arrow = db.Arrows.Find(id);
            if (arrow == null)
            {
                return HttpNotFound();
            }
            return View(arrow);
        }

        // POST: Arrows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arrow arrow = db.Arrows.Find(id);
            db.Items.Remove(arrow);
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
