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
    public class AttendencesController : Controller
    {
       private DB5Entities3 db = new DB5Entities3();

        // GET: Attendences
        public ActionResult Index()
        {
            var attendences = db.Attendences.Include(a => a.Staff);
            return View();
        }

        // GET: Attendences/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Attendences/Create
        public ActionResult Create()
        {
            ViewBag.StaffID = new SelectList(db.Staffs, "StaffID", "FirstName");
            return View();
        }

        // POST: Attendences/Create
       
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




        // GET: Attendences/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attendences/Edit/5
        
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

        // GET: Attendences/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attendences/Delete/5
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
