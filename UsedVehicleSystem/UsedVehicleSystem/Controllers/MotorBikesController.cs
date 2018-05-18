using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UsedVehicleSystem.Models;

namespace UsedVehicleSystem.Controllers
{
    public class MotorBikesController : Controller
    {
        private VehiclesDBContext db = new VehiclesDBContext();

        // GET: MotorBikes
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.MotorBikes.ToList());
        }

        // GET: MotorBikes/Details/5
        [Authorize(Roles = "Admin,User")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorBike motorBike = db.MotorBikes.Find(id);
            if (motorBike == null)
            {
                return HttpNotFound();
            }
            return View(motorBike);
        }

        // GET: MotorBikes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MotorBikes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,title,model,make,estimatedPrice,drivenInKms,documents,condition,imageUrl")] MotorBike motorBike,HttpPostedFileBase imgFile)
        {
            string fileName = Path.GetFileNameWithoutExtension(imgFile.FileName);
            string extension = Path.GetExtension(imgFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            motorBike.imageUrl = "/Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
            imgFile.SaveAs(fileName);
            motorBike.userID = User.Identity.GetUserId();
       //     if (ModelState.IsValid)
        //    {
                db.MotorBikes.Add(motorBike);
                db.SaveChanges();
                return RedirectToAction("Create", "Users");
         //   }

       //     return View(motorBike);
        }

        // GET: MotorBikes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorBike motorBike = db.MotorBikes.Find(id);
            if (motorBike == null)
            {
                return HttpNotFound();
            }
            return View(motorBike);
        }

        // POST: MotorBikes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,title,model,make,estimatedPrice,drivenInKms,documents,condition,")] MotorBike motorBike)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorBike).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorBike);
        }

        // GET: MotorBikes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorBike motorBike = db.MotorBikes.Find(id);
            if (motorBike == null)
            {
                return HttpNotFound();
            }
            return View(motorBike);
        }

        // POST: MotorBikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MotorBike motorBike = db.MotorBikes.Find(id);
            db.MotorBikes.Remove(motorBike);
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
