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
    public class IounStonesController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: IounStones
        public ActionResult Index()
        {
            var items = db.IounStones.Include(i => i.Rarity);
            return View(items.ToList());
        }

        // GET: IounStones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IounStone iounStone = db.IounStones.Find(id);
            if (iounStone == null)
            {
                return HttpNotFound();
            }
            return View(iounStone);
        }

        // GET: IounStones/Create
        public ActionResult Create()
        {
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId");
            return View();
        }

        // POST: IounStones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,RarityId,Source")] IounStone iounStone)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(iounStone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", iounStone.RarityId);
            return View(iounStone);
        }

        // GET: IounStones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IounStone iounStone = db.IounStones.Find(id);
            if (iounStone == null)
            {
                return HttpNotFound();
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", iounStone.RarityId);
            return View(iounStone);
        }

        // POST: IounStones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,RarityId,Source")] IounStone iounStone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iounStone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RarityId = new SelectList(db.Rarities, "RarityId", "RarityId", iounStone.RarityId);
            return View(iounStone);
        }

        // GET: IounStones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IounStone iounStone = db.IounStones.Find(id);
            if (iounStone == null)
            {
                return HttpNotFound();
            }
            return View(iounStone);
        }

        // POST: IounStones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IounStone iounStone = db.IounStones.Find(id);
            db.Items.Remove(iounStone);
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
