﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Medicine_Store.Controllers
{
    public class SalesmanController : Controller
    {
        // GET: Salesman
        public ActionResult Index()
        {
            return View();
        }

        // GET: Salesman/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salesman/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salesman/Create
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

        // GET: Salesman/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salesman/Edit/5
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

        // GET: Salesman/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salesman/Delete/5
        [HttpPost]
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
