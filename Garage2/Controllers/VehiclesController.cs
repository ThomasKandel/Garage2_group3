using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2.Models;
using Garage2.DataAccess;
namespace Garage2.Controllers
{
    public class VehiclesController : Controller
    {
        private ParkingContext db = new ParkingContext();

        // GET: Vehicles
        public ActionResult Index(string orderBy, string searchString)
        {
            ViewBag.RegNumSortParm = orderBy == "RegNum" ? "RegNum_desc" : "RegNum";
            ViewBag.VehicleTypeSortParm = orderBy == "VehicleType" ? "VehicleType_desc" : "VehicleType";
            ViewBag.ColorSortParm = orderBy == "Color" ? "Color_desc" : "Color";
            ViewBag.BrandSortParm = orderBy == "Brand" ? "Brand_desc" : "Brand";



            var vehicles = db.Vehicles.Select(p => p); 
            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                vehicles = vehicles.Where(p => p.RegNum.Equals(searchString));
            }

            switch (orderBy)
            {
                case "RegNum":
                    vehicles = vehicles.OrderBy(p => p.RegNum);
                    break;
                case "RegNum_desc":
                    vehicles = vehicles.OrderByDescending(p => p.RegNum);
                    break;
                case "VehicleType":
                    vehicles = vehicles.OrderBy(p => p.Type);
                    break;
                case "VehicleType_desc":
                    vehicles = vehicles.OrderByDescending(p => p.Type);
                    break;
                case "Color":
                    vehicles = vehicles.OrderBy(p => p.Color);
                    break;
                case "Color_desc":
                    vehicles = vehicles.OrderByDescending(p => p.Color);
                    break;
                case "Brand":
                    vehicles = vehicles.OrderBy(p => p.Brand);
                    break;
                case "Brand_desc":
                    vehicles = vehicles.OrderByDescending(p => p.Brand);
                    break;
            }

               return View(vehicles.ToList());
            }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegNum,Type,Color,Brand,Model,Wheels,CheckInTime,CheckOutTime")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RegNum,Type,Color,Brand,Model,Wheels,CheckInTime,CheckOutTime")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
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
