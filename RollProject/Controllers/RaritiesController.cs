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
    public class RaritiesController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Rarities
        public ActionResult Index()
        {
            return View(db.Rarities.ToList());
        }

        // GET: Rarities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rarity rarity = db.Rarities.Find(id);
            if (rarity == null)
            {
                return HttpNotFound();
            }
            return View(rarity);
        }

        // GET: Rarities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rarities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RarityId")] Rarity rarity)
        {
            if (ModelState.IsValid)
            {
                db.Rarities.Add(rarity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rarity);
        }

        // GET: Rarities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rarity rarity = db.Rarities.Find(id);
            if (rarity == null)
            {
                return HttpNotFound();
            }
            return View(rarity);
        }

        // POST: Rarities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RarityId")] Rarity rarity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rarity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rarity);
        }

        // GET: Rarities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rarity rarity = db.Rarities.Find(id);
            if (rarity == null)
            {
                return HttpNotFound();
            }
            return View(rarity);
        }

        // POST: Rarities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rarity rarity = db.Rarities.Find(id);
            db.Rarities.Remove(rarity);
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
