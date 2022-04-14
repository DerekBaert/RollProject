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
    public class MagicItemsController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: MagicItems
        public ActionResult Index()
        {
            var items = db.MagicItems.Include(m => m.Rarity);
            return View(items.ToList());
        }

        // GET: MagicItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MagicItem magicItem = db.MagicItems.Find(id);
            if (magicItem == null)
            {
                return HttpNotFound();
            }
            return View(magicItem);
        }

        // GET: MagicItems/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: MagicItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] MagicItem magicItem)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(magicItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", magicItem.RarityId);
            return View(magicItem);
        }

        // GET: MagicItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MagicItem magicItem = db.MagicItems.Find(id);
            if (magicItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", magicItem.RarityId);
            return View(magicItem);
        }

        // POST: MagicItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] MagicItem magicItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(magicItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", magicItem.RarityId);
            return View(magicItem);
        }

        // GET: MagicItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MagicItem magicItem = db.MagicItems.Find(id);
            if (magicItem == null)
            {
                return HttpNotFound();
            }
            return View(magicItem);
        }

        // POST: MagicItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MagicItem magicItem = db.MagicItems.Find(id);
            db.Items.Remove(magicItem);
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
