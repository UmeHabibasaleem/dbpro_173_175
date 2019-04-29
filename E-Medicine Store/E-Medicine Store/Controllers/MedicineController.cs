using E_Medicine_Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Medicine_Store.Controllers
{
    public class MedicineController : Controller
    {
        DB5Entities5 db = new DB5Entities5();
        // GET: Medicine
        public ActionResult Index()
        {
            try
            {
                List<Medicine> list = db.Medicines.ToList();
                List<MedicineViewModel> viewList = new List<MedicineViewModel>();
                foreach (Medicine s in list)
                {
                   MedicineViewModel obj = new MedicineViewModel();
                    obj.MedId = s.MedId;
                    obj.MedicineName = s.MedicineName;
                    obj.Company= s.Company;
                    obj.Description = s.Description;
                    obj.Measurement = s.Measurement;
                    obj.Price = s.Price;
                    obj.StockID = s.StockID;
                    obj.CategoryID = s.CategoryID;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // GET: Medicine/Details/5
        public ActionResult Details(int? id)
        {
            MedicineViewModel obj = new MedicineViewModel();
            Medicine s = db.Medicines.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.MedId= s.MedId;
                obj.MedicineName = s.MedicineName;
                obj.Company = s.Company;
                obj.Description = s.Description;
                obj.Measurement= s.Measurement;
                obj.Price = s.Price;
                obj.StockID = s.StockID;

                obj.CategoryID= s.CategoryID;


            }
            return View(obj);
            
        }

        // GET: Medicine/Create
        [HttpGet]
        public ActionResult Create()
        {
            MedicineViewModel medicine = new MedicineViewModel();
            using (DB5Entities5 db = new DB5Entities5())
            {

                medicine.StockCollection = db.Stocks.ToList<Stock>();
                medicine.CategoryCollection = db.Categories.ToList<Category>();

            }

            return View(medicine);
            
        }

        // POST: Medicine/Create
        [HttpPost]
        public ActionResult Create(MedicineViewModel obj)
        {
            try
            {
                Medicine s = new Medicine();
                s.MedicineName = obj.MedicineName;
                s.Company = obj.Company;
                s.Description = obj.Description;
                s.Measurement = obj.Measurement;
                s.Price = obj.Price;
                s.StockID = obj.StockID;
                s.CategoryID = obj.CategoryID;
                db.Medicines.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Medicine/Edit/5
        public ActionResult Edit(int? id)
        {
            MedicineViewModel obj = new MedicineViewModel();
            Medicine s = db.Medicines.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.MedId = s.MedId;
                obj.MedicineName = s.MedicineName;
                obj.Company = s.Company;
                obj.Description = s.Description;
                obj.Measurement= s.Measurement;
                obj.Price = s.Price;
                obj.StockID = s.StockID;
                obj.CategoryID = s.CategoryID;
            }
            return View(obj);
            
        }

        // POST: Medicine/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, MedicineViewModel obj)
        {
            try
            {
                //db.Salesmen.Find(id).SalesmanID = obj.SalesmanID;
                db.Medicines.Find(id).MedicineName= obj.MedicineName;
                db.Medicines.Find(id).Company = obj.Company;
                db.Medicines.Find(id).Description = obj.Description;
                db.Medicines.Find(id).Measurement = obj.Measurement;
                db.Medicines.Find(id).Price = obj.Price;
                db.Medicines.Find(id).StockID = obj.StockID;
                db.Medicines.Find(id).CategoryID = obj.CategoryID;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medicine/Delete/5
        public ActionResult Delete(int? id)
        {
            MedicineViewModel obj = new MedicineViewModel();
            Medicine s = db.Medicines.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.MedId = s.MedId;
                obj.MedicineName = s.MedicineName;
                obj.Company = s.Company;
                obj.Description= s.Description;
                obj.Measurement = s.Measurement;
                obj.Price = s.Price;
                obj.StockID = s.StockID;
                obj.CategoryID = s.CategoryID;
            }
            return View(obj);
          
        }

        // POST: Medicine/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, MedicineViewModel obj)
        {
            try
            {
                var v = db.Medicines.Where(a => a.MedId == id).First();
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
