using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UsedVehicleSystem.Models;

namespace UsedVehicleSystem.Controllers
{
    public class OfficeLocationsController : Controller
    {
        private VehiclesDBContext db = new VehiclesDBContext();

        // GET: OfficeLocations
        [Authorize(Roles ="Admin,User")]
        public ActionResult Index()
        {
            return View(db.OfficeLocations.ToList());
        }
        [Authorize(Roles = "Admin,User")]
        public ActionResult IndexUser()
        {
            return View(db.OfficeLocations.ToList());
        }
        //GET: OfficeLocations/Details/5
        [Authorize(Roles = "Admin,User")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocations officeLocations = db.OfficeLocations.Find(id);
            if (officeLocations == null)
            {
                return HttpNotFound();
            }
            return View(officeLocations);
        }

        // GET: OfficeLocations/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficeLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "ID,Address,StateOrProvince,CityName,ZipCode")] OfficeLocations officeLocations)
        {
            if (ModelState.IsValid)
            {
                db.OfficeLocations.Add(officeLocations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(officeLocations);
        }

        // GET: OfficeLocations/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocations officeLocations = db.OfficeLocations.Find(id);
            if (officeLocations == null)
            {
                return HttpNotFound();
            }
            return View(officeLocations);
        }

        // POST: OfficeLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "ID,Address,StateOrProvince,CityName,ZipCode")] OfficeLocations officeLocations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(officeLocations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(officeLocations);
        }

        // GET: OfficeLocations/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfficeLocations officeLocations = db.OfficeLocations.Find(id);
            if (officeLocations == null)
            {
                return HttpNotFound();
            }
            return View(officeLocations);
        }

        // POST: OfficeLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            OfficeLocations officeLocations = db.OfficeLocations.Find(id);
            db.OfficeLocations.Remove(officeLocations);
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
