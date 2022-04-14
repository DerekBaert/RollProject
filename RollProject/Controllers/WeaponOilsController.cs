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
    public class WeaponOilsController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: WeaponOils
        public ActionResult Index()
        {
            var items = db.WeaponOils.Include(w => w.Rarity);
            return View(items.ToList());
        }

        // GET: WeaponOils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeaponOil weaponOil = db.WeaponOils.Find(id);
            if (weaponOil == null)
            {
                return HttpNotFound();
            }
            return View(weaponOil);
        }

        // GET: WeaponOils/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: WeaponOils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] WeaponOil weaponOil)
        {
            if (ModelState.IsValid)
            {
                db.WeaponOils.Add(weaponOil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", weaponOil.RarityId);
            return View(weaponOil);
        }

        // GET: WeaponOils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeaponOil weaponOil = db.WeaponOils.Find(id);
            if (weaponOil == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", weaponOil.RarityId);
            return View(weaponOil);
        }

        // POST: WeaponOils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] WeaponOil weaponOil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weaponOil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", weaponOil.RarityId);
            return View(weaponOil);
        }

        // GET: WeaponOils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeaponOil weaponOil = db.WeaponOils.Find(id);
            if (weaponOil == null)
            {
                return HttpNotFound();
            }
            return View(weaponOil);
        }

        // POST: WeaponOils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WeaponOil weaponOil = db.WeaponOils.Find(id);
            db.WeaponOils.Remove(weaponOil);
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
