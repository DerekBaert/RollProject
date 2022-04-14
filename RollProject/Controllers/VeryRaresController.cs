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
    public class VeryRaresController : Controller
    {
        private RollProjectContext db = new RollProjectContext();

        // GET: VeryRares
        public ActionResult Index()
        {
            return View(VeryRare.GetInstance());
        }

        // GET: VeryRares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeryRare veryRare = db.VeryRares.Find(id);
            if (veryRare == null)
            {
                return HttpNotFound();
            }
            return View(veryRare);
        }

        // GET: VeryRares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VeryRares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RarityId")] VeryRare veryRare)
        {
            if (ModelState.IsValid)
            {
                db.VeryRares.Add(veryRare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veryRare);
        }

        // GET: VeryRares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeryRare veryRare = db.VeryRares.Find(id);
            if (veryRare == null)
            {
                return HttpNotFound();
            }
            return View(veryRare);
        }

        // POST: VeryRares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RarityId")] VeryRare veryRare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veryRare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veryRare);
        }

        // GET: VeryRares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VeryRare veryRare = db.VeryRares.Find(id);
            if (veryRare == null)
            {
                return HttpNotFound();
            }
            return View(veryRare);
        }

        // POST: VeryRares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VeryRare veryRare = db.VeryRares.Find(id);
            db.VeryRares.Remove(veryRare);
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
