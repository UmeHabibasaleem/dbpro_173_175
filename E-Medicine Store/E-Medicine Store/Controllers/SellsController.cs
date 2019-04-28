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
        private DB5Entities5 db = new DB5Entities5();

        // GET: Sells
        public ActionResult Index()
        {
            try { 
            List<Sell> list = db.Sells.ToList();
            List<SellsViewModel> viewList = new List<SellsViewModel>();
            foreach (Sell s in list)
            {
                SellsViewModel obj = new SellsViewModel();
                obj.SellId = s.SellId;
                obj.MedId = s.MedId;
                obj.Price = s.Price;
                obj.StaffId = s.StaffId;
                obj.CustomerName = s.CustomerName;
                obj.Date = s.Date;

                viewList.Add(obj);
            }
            return View(viewList);
        }
        
            catch (Exception ex)
            {
                throw ex;
            }

}

     // GET: Sells/Details/5
         public ActionResult Details(int? id)
        {
            SellsViewModel obj = new SellsViewModel();
            Sell s = db.Sells.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SellId = s.SellId;
                obj.MedId= s.MedId;
                obj.Price = s.Price;
                obj.StaffId = s.StaffId;
                obj.CustomerName = s.CustomerName;
                obj.Date = s.Date;
               


            }
            return View(obj);
        }
        [HttpGet]
        // GET: Sells/Create
        public ActionResult Create()
        {
           SellsViewModel sells = new SellsViewModel();
            using (DB5Entities5 db = new DB5Entities5())
            {

                sells.MedicineCollection = db.Medicines.ToList<Medicine>();
                sells.StaffData = db.Staffs.ToList<Staff>();

            }

            return View(sells);
        }

        // POST: Sells/Create
        
        [HttpPost]
        public ActionResult Create(SellsViewModel obj)
        {
            try
            {
                Sell s = new Sell();
                s.MedId = obj.MedId;
                s.Price = obj.  Price;
                s.StaffId = obj.StaffId;
                s.CustomerName = obj.CustomerName;
                s.Date = obj.Date;
                
                db.Sells.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Sells/Edit/5
        public ActionResult Edit(int? id)
        {
            SellsViewModel obj = new SellsViewModel();
            Sell s = db.Sells.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SellId = s.SellId;
                obj.MedId = s.MedId;
                obj.Price = s.Price;
                obj.StaffId = s.StaffId;
                obj.CustomerName = s.CustomerName;
                obj.Date = s.Date;
                
            }
            return View(obj);

        }
        // POST: Sells/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, SellsViewModel obj)
        {
            try
            {
                //db.Salesmen.Find(id).SalesmanID = obj.SalesmanID;
                db.Sells.Find(id).MedId= obj.MedId;
                db.Sells.Find(id).Price = obj.Price;
                db.Sells.Find(id).StaffId = obj.StaffId;
                db.Sells.Find(id).CustomerName = obj.CustomerName;
                db.Sells.Find(id).Date = obj.Date;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sells/Delete/5
        public ActionResult Delete(int? id)
        {
            SellsViewModel obj = new SellsViewModel();
           Sell s = db.Sells.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SellId = s.SellId;

                obj.MedId = s.MedId;
                obj.StaffId = s.StaffId;
                obj.Price = s.Price;

                obj.CustomerName = s.CustomerName;
                obj.Date = s.Date;
                
            }
            return View(obj);

        }

        // POST: Sells/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id,SellsViewModel obj)
        {
            try
            {
                var v = db.Sells.Where(a => a.SellId == id).First();
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
