using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsedVehicleSystem.Models;

namespace UsedVehicleSystem.Controllers
{
    public class HomeController : Controller
    {
        private VehiclesDBContext db = new VehiclesDBContext();

        public ActionResult Index(string searchString)
        {
            ViewBag.Cars = db.Cars.ToList();
            ViewBag.Bikes = db.Bikes.ToList();
            ViewBag.MotorBikes = db.MotorBikes.ToList();

            var autoCar = from m in db.Cars
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                autoCar = autoCar.Where(s => s.title.Contains(searchString)); 
            }
            ViewBag.searchedCars = autoCar;

            var autoBike = from m in db.MotorBikes
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                autoBike = autoBike.Where(s => s.title.Contains(searchString));
            }
            ViewBag.searchedBikes = autoBike;

            var autoCycle = from m in db.Bikes
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                autoCycle = autoCycle.Where(s => s.title.Contains(searchString));
            }
            ViewBag.searchedCycles = autoCycle;

            return View();
        }


        public ActionResult MyAdsList() {
            var id = User.Identity.GetUserId();
            ViewBag.Cars = db.Cars.Where(d => d.userID.Equals(id)).ToList();
            ViewBag.Bikes = db.Bikes.Where(d => d.userID.Equals(id)).ToList();
            ViewBag.MotorBikes = db.MotorBikes.Where(d => d.userID.Equals(id)).ToList();
            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Roles ="Admin,User")]
        public ActionResult SaleVehicle()
        {
            ViewBag.Message = "Your SaleVehicle page.";

            return View();
        }
        public ActionResult PurchaseVehicle()
        {
            ViewBag.Message = "Your PurchaseVehicle page.";

            return View();
        }
        public ActionResult Locations()
        {
            ViewBag.Message = "Your Office Locations page.";

            return View();
        }
    }
}