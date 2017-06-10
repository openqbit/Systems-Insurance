using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Insurance.Common.Models;
using OpenQbit.Insurance.DataAccess.DAL;

namespace DALTest.Controllers
{
    public class ClientController : Controller
    {
        private InsuranceDBContext db = new InsuranceDBContext();

        // GET: Client
        public ActionResult Index()
        {
            return View(db.Client.ToList());
        }

        // GET: Client/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = db.Client.Find(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,First_Name,Middle_Name,Last_Name,Age,Address,Date_of_Birth,Gender,Nationality,Religion,BloodGroup,Email,Mobile,Telephone")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(clientModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientModel);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = db.Client.Find(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,First_Name,Middle_Name,Last_Name,Age,Address,Date_of_Birth,Gender,Nationality,Religion,BloodGroup,Email,Mobile,Telephone")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientModel);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = db.Client.Find(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientModel clientModel = db.Client.Find(id);
            db.Client.Remove(clientModel);
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
