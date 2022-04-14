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
    public class RaresController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: Rares
        public ActionResult Index()
        {
            return View(Rare.GetInstance());
        }

        // GET: Rares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rare rare = db.Rares.Find(id);
            if (rare == null)
            {
                return HttpNotFound();
            }
            return View(rare);
        }

        // GET: Rares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RarityId")] Rare rare)
        {
            if (ModelState.IsValid)
            {
                db.Rarities.Add(rare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rare);
        }

        // GET: Rares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rare rare = db.Rares.Find(id);
            if (rare == null)
            {
                return HttpNotFound();
            }
            return View(rare);
        }

        // POST: Rares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RarityId")] Rare rare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rare);
        }

        // GET: Rares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rare rare = db.Rares.Find(id);
            if (rare == null)
            {
                return HttpNotFound();
            }
            return View(rare);
        }

        // POST: Rares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rare rare = db.Rares.Find(id);
            db.Rarities.Remove(rare);
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
