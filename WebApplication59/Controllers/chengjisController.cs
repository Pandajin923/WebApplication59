using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication59.Models;

namespace WebApplication59.Controllers
{
    public class chengjisController : Controller
    {
        private MyDb db = new MyDb();

        // GET: chengjis
        public ActionResult Index()
        {
            return View(db.chengjis.ToList());
        }

        // GET: chengjis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chengji chengji = db.chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // GET: chengjis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: chengjis/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "xuhao,xueshengxuehao,Xueshengxingming,Xueshengxingbie,kechengmingchen,kechengchengji")] chengji chengji)
        {
            if (ModelState.IsValid)
            {
                db.chengjis.Add(chengji);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chengji);
        }

        // GET: chengjis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chengji chengji = db.chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // POST: chengjis/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "xuhao,xueshengxuehao,Xueshengxingming,Xueshengxingbie,kechengmingchen,kechengchengji")] chengji chengji)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chengji).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chengji);
        }

        // GET: chengjis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chengji chengji = db.chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // POST: chengjis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            chengji chengji = db.chengjis.Find(id);
            db.chengjis.Remove(chengji);
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
