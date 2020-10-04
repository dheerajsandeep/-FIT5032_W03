using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class dataModelsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: dataModels
        public ActionResult Index(string searchQry,string searchIns)
        {
            var insList = new List<string>();
            var insQry = from d in db.dataModels
                         orderby d.Teacher
                         select d.Teacher;
            insList.AddRange(insQry.Distinct());
            ViewBag.searchIns = new SelectList(insList);

            var classes = from c in db.dataModels
                           select c;
            if(!string.IsNullOrEmpty(searchQry))
            {
                classes = classes.Where(s => s.Class.Contains(searchQry));
            }
            if (!string.IsNullOrEmpty(searchIns))
            {
                classes = classes.Where(x => x.Teacher == searchIns);
            }
            return View(classes);
        }

        // GET: dataModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataModel dataModel = db.dataModels.Find(id);
            if (dataModel == null)
            {
                return HttpNotFound();
            }
            return View(dataModel);
        }

        // GET: dataModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dataModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Class,Date,Field,Fee,Teacher,Venue,Rating")] dataModel dataModel)
        {
            if (ModelState.IsValid)
            {
                db.dataModels.Add(dataModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dataModel);
        }

        // GET: dataModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataModel dataModel = db.dataModels.Find(id);
            if (dataModel == null)
            {
                return HttpNotFound();
            }
            return View(dataModel);
        }

        // POST: dataModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Class,Date,Field,Fee,Teacher,Venue,Rating")] dataModel dataModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dataModel);
        }

        // GET: dataModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataModel dataModel = db.dataModels.Find(id);
            if (dataModel == null)
            {
                return HttpNotFound();
            }
            return View(dataModel);
        }

        // POST: dataModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dataModel dataModel = db.dataModels.Find(id);
            db.dataModels.Remove(dataModel);
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
