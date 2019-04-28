using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  E_Medicine_Store.Models;
namespace E_Medicine_Store.Controllers
{
    public class SalesmanController : Controller
    {
        DB5Entities5 db = new DB5Entities5();
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
        [HttpGet]
        public ActionResult Create()
        {
          SalesmanViewModel salesman = new SalesmanViewModel();
            using (DB5Entities5 db = new DB5Entities5())
            {
                
               salesman.CompanyCollection = db.Comapnies.ToList<Comapny>();
            }

                return View(salesman);
        }

      

        // POST: Salesman/Create
        [HttpPost]
        public ActionResult Create(SalesmanViewModel sales)
        {
          
                return View();
            
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
