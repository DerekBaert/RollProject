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
    public class FigurinesController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Figurines
        public ActionResult Index()
        {
            var items = db.Figurines.Include(f => f.Rarity);
            return View(items.ToList());
        }

        // GET: Figurines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Figurine figurine = db.Figurines.Find(id);
            if (figurine == null)
            {
                return HttpNotFound();
            }
            return View(figurine);
        }

        // GET: Figurines/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: Figurines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] Figurine figurine)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(figurine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", figurine.RarityId);
            return View(figurine);
        }

        // GET: Figurines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Figurine figurine = db.Figurines.Find(id);
            if (figurine == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", figurine.RarityId);
            return View(figurine);
        }

        // POST: Figurines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] Figurine figurine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(figurine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", figurine.RarityId);
            return View(figurine);
        }

        // GET: Figurines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Figurine figurine = db.Figurines.Find(id);
            if (figurine == null)
            {
                return HttpNotFound();
            }
            return View(figurine);
        }

        // POST: Figurines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Figurine figurine = db.Figurines.Find(id);
            db.Items.Remove(figurine);
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
