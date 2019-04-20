using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;

namespace E_Medicine_Store
{
    public class StaffsController : Controller
    {
        private DB5Entities1 db = new DB5Entities1();

        // GET: Staffs
        public ActionResult Index()
        {
            return View();
        }

        // GET: Staffs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staffs/Create
        
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


        // GET: Staffs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: Staffs/Edit/5
       
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

        // GET: Staffs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staffs/Delete/5
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
