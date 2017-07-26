using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Insurance.Presentation.Web.Models;
using OpenQbit.Insurance.Presentation.Web.Models.API;

namespace OpenQbit.Insurance.Presentation.Web.Models.API.Contract
{
    public class ApiClientModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ApiClientModels
        public ActionResult Index()
        {
            return View(db.ApiClientModels.ToList());
        }

        // GET: ApiClientModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApiClientModel apiClientModel = db.ApiClientModels.Find(id);
            if (apiClientModel == null)
            {
                return HttpNotFound();
            }
            return View(apiClientModel);
        }

        // GET: ApiClientModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApiClientModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,First_Name,Middle_Name,Last_Name,Age,Address,Date_of_Birth,Gender,Nationality,Religion,BloodGroup,Email,Mobile,Telephone")] ApiClientModel apiClientModel)
        {
            if (ModelState.IsValid)
            {
                db.ApiClientModels.Add(apiClientModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apiClientModel);
        }

        // GET: ApiClientModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApiClientModel apiClientModel = db.ApiClientModels.Find(id);
            if (apiClientModel == null)
            {
                return HttpNotFound();
            }
            return View(apiClientModel);
        }

        // POST: ApiClientModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,First_Name,Middle_Name,Last_Name,Age,Address,Date_of_Birth,Gender,Nationality,Religion,BloodGroup,Email,Mobile,Telephone")] ApiClientModel apiClientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apiClientModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apiClientModel);
        }

        // GET: ApiClientModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApiClientModel apiClientModel = db.ApiClientModels.Find(id);
            if (apiClientModel == null)
            {
                return HttpNotFound();
            }
            return View(apiClientModel);
        }

        // POST: ApiClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApiClientModel apiClientModel = db.ApiClientModels.Find(id);
            db.ApiClientModels.Remove(apiClientModel);
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
