using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoundBarrierHunting.Models.Database;
using SoundBarrierHunting.Domain.Concrete;

namespace SoundBarrierHunting.Controllers
{
    public class SubscriberInfoController : Controller
    {
        private DatabaseEntity db = new DatabaseEntity();

        // GET: SubscriberInfo
        public ActionResult Index()
        {
            return View(db.SubscriberInfoes.ToList());
        }

        // GET: SubscriberInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriberInfo subscriberInfo = db.SubscriberInfoes.Find(id);
            if (subscriberInfo == null)
            {
                return HttpNotFound();
            }
            return View(subscriberInfo);
        }

        // GET: SubscriberInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubscriberInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,SubscribeDate")] SubscriberInfo subscriberInfo)
        {
            if (ModelState.IsValid)
            {
                db.SubscriberInfoes.Add(subscriberInfo);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(subscriberInfo);
        }

        // GET: SubscriberInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriberInfo subscriberInfo = db.SubscriberInfoes.Find(id);
            if (subscriberInfo == null)
            {
                return HttpNotFound();
            }
            return View(subscriberInfo);
        }

        // POST: SubscriberInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,IsSubscribed")] SubscriberInfo subscriberInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subscriberInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscriberInfo);
        }

        // GET: SubscriberInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriberInfo subscriberInfo = db.SubscriberInfoes.Find(id);
            if (subscriberInfo == null)
            {
                return HttpNotFound();
            }
            return View(subscriberInfo);
        }

        // POST: SubscriberInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubscriberInfo subscriberInfo = db.SubscriberInfoes.Find(id);
            db.SubscriberInfoes.Remove(subscriberInfo);
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
