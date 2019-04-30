using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;
using System.Data.Entity;

namespace E_Medicine_Store.Controllers
{
    public class SalesmanController : Controller
    {
        DB5Entities5 db = new DB5Entities5();
        // GET: Salesman
        public ActionResult Index()
        {
            try
            {
                List<Salesman> list = db.Salesmen.ToList();
                List<SalesmanViewModel> viewList = new List<SalesmanViewModel>();
                foreach (Salesman s in list)
                {
                    SalesmanViewModel obj = new SalesmanViewModel();
                    obj.SalesmanID = s.SalesmanID;
                    obj.Name= s.Name;
                    obj.CNIC = s.CNIC;
                    obj.Phone = s.Phone;
                    obj.CompanyID = s.CompanyID;
                    obj.StockID = s.StockID;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        // GET: Salesman/Details/5
        public ActionResult Details(int? id)
        {
            SalesmanViewModel obj = new SalesmanViewModel();
            Salesman s = db.Salesmen.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalesmanID = s.SalesmanID;
                obj.Name = s.Name;
                obj.CNIC = s.CNIC;
                obj.Phone = s.Phone;
                obj.CompanyID = s.CompanyID;
                obj.StockID = s.StockID;

               
            }
            return View(obj);
          
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
        public ActionResult Create(SalesmanViewModel obj)
        {
            try
            {
                Salesman s = new Salesman();
                s.Name = obj.Name;
                s.CNIC = obj.CNIC;
                s.Phone = obj.Phone;
                s.CompanyID = obj.CompanyID;
                s.StockID = obj.StockID;

                db.Salesmen.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }


        }

        // GET: Salesman/Edit/5
        public ActionResult Edit(int? id)
        {
            SalesmanViewModel obj = new SalesmanViewModel();
            Salesman s = db.Salesmen.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalesmanID = s.SalesmanID;
                obj.Name = s.Name;
                obj.CNIC = s.CNIC;
                obj.Phone = s.Phone;
                obj.CompanyID = s.CompanyID;
                obj.StockID = s.StockID;
            }
            return View(obj);
        }

        // POST: Salesman/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, SalesmanViewModel obj)
        {
            try
            {
                //db.Salesmen.Find(id).SalesmanID = obj.SalesmanID;
                db.Salesmen.Find(id).Name = obj.Name;
                db.Salesmen.Find(id).Phone = obj.Phone;
                db.Salesmen.Find(id).CompanyID = obj.CompanyID;
                db.Salesmen.Find(id).StockID = obj.StockID;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        // GET: Salesman/Delete/5
        public ActionResult Delete(int? id)
        {
            SalesmanViewModel obj = new SalesmanViewModel();
            Salesman s = db.Salesmen.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalesmanID = s.SalesmanID;
                obj.Name = s.Name;
                obj.Phone = s.Phone;
                obj.CompanyID = s.CompanyID;
                obj.StockID = s.StockID;
            }
            return View(obj);
            
        }

        // POST: Salesman/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, SalesmanViewModel obj)
        {
            try
            {
                var v = db.Salesmen.Where(a => a.SalesmanID == id).First();
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
