using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;

namespace E_Medicine_Store.Controllers
{
    public class SellsController : Controller
    {
        private DB5Entities1 db = new DB5Entities1();

        // GET: Sells
        public ActionResult Index()
        {
            var sells = db.Sells.Include(s => s.Medicine);
            return View(sells.ToList());
        }

        // GET: Sells/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sells/Create
        public ActionResult Create()
        {
            ViewBag.MedID = new SelectList(db.Medicines, "MedID", "Name");
            return View();
        }

        // POST: Sells/Create
        
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sells/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sells/Edit/5
      
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Sells/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sells/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
