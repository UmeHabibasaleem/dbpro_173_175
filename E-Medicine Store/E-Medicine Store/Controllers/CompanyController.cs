using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;
using System.Data.Entity;

namespace E_Medicine_Store.Controllers
{
    public class CompanyController : Controller
    {
        DB5Entities5 db = new DB5Entities5();
        // GET: Company
        public ActionResult Index()
        {
          try
          {
             List<Comapny> list = db.Comapnies.ToList();
             List<CompnayViewModel> viewList = new List<CompnayViewModel>();
             foreach (Comapny C in list)
             {
               CompnayViewModel obj = new CompnayViewModel();
               obj.CompanyID = C.CompanyID;
               obj.Name = C.CompanyName;
               obj.CompanyAddress = C.CompanyAddress;
               obj.CompanyType = C.CompanyType;
               viewList.Add(obj);
              }
                return View(viewList);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET: Company/Details/5
        public ActionResult Details(int? id)
        {
            CompnayViewModel obj = new CompnayViewModel();
            Comapny c = db.Comapnies.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.CompanyID = c.CompanyID;
                obj.Name = c.CompanyName;
                obj.CompanyAddress = c.CompanyAddress;
                obj.CompanyType = c.CompanyType;
            }
            return View(obj);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(CompnayViewModel obj)
        {
           try
            {
                // TODO: Add insert logic here

                Comapny C1 = new Comapny();
                C1.CompanyName = obj.Name;
                C1.CompanyType= obj.CompanyType;
                C1.CompanyAddress = obj.CompanyAddress;
                db.Comapnies.Add(C1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int? id)
        {
            CompnayViewModel obj = new CompnayViewModel();
            Comapny c = db.Comapnies.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.Name = c.CompanyName;
                obj.CompanyAddress = c.CompanyAddress;
                obj.CompanyType = c.CompanyType;
            }
            return View(obj);
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, CompnayViewModel obj)
        {
            try
            {
                db.Comapnies.Find(id).CompanyName = obj.Name;
                db.Comapnies.Find(id).CompanyAddress = obj.CompanyAddress;
                db.Comapnies.Find(id).CompanyType = obj.CompanyType;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int? id)
        {
            CompnayViewModel obj = new CompnayViewModel();
            Comapny c = db.Comapnies.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.CompanyID = c.CompanyID;
                obj.Name = c.CompanyName;
                obj.CompanyAddress = c.CompanyAddress;
                obj.CompanyType = c.CompanyType;
            }
            return View(obj);
        }

        // POST: Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, CompnayViewModel obj)
        {
            try
            {
                // TODO: Add insert logic here

                var v = db.Comapnies.Where(a => a.CompanyID == id).First();
                db.Entry(v).State = EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
