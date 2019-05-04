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
    public class SalaryStatusController : Controller
    {
        private DB5Entities5 db = new DB5Entities5();

        // GET: SalaryStatus
        public ActionResult Index()
        {
            try
            {
                List<SalaryStatu> list = db.SalaryStatus.ToList();
                List<SalaryStatusViewModel> viewList = new List<SalaryStatusViewModel>();
                foreach (SalaryStatu s in list)
                {
                    SalaryStatusViewModel obj = new SalaryStatusViewModel();
                    obj.ID = s.ID;
                    obj.SalaryID = s.SalaryID;
                    obj.StaffID = s.StaffID;
                    obj.Status = s.Status;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: SalaryStatus/Details/5
        public ActionResult Details(int? id)
        {
            SalaryStatusViewModel obj = new SalaryStatusViewModel();
            SalaryStatu s = db.SalaryStatus.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.ID = s.ID;
                obj.SalaryID = s.SalaryID;
                obj.StaffID = s.StaffID;
                obj.Status = s.Status;


            }
            return View(obj);
        }
        [HttpGet]
        // GET: SalaryStatus/Create
        public ActionResult Create()
        {
            SalaryStatusViewModel salary = new SalaryStatusViewModel();
            var id = (int)Session["OwnerId"];
            salary.SalaryCollection = db.Salaries.ToList<Salary>();
            List<Staff> list = db.Staffs.ToList();
            List<Staff> list2 = new List<Staff>();
            foreach (Staff s in list)
            {
                if (s.OwnerId == id)
                {
                    list2.Add(s);
                }
            }
            salary.StaffCollection = list2;
            return View(salary);
        }

        // POST: SalaryStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // POST: Salesman/Create
       
        public ActionResult Create(SalaryStatusViewModel obj)
        {
            try
            {
                SalaryStatu s = new SalaryStatu();
                s.ID = obj.ID;
                s.SalaryID = obj.SalaryID;
                s.StaffID = obj.StaffID;
                s.Status= obj.Status;
                db.SalaryStatus.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }


        }

        // GET: SalaryStatus/Edit/5
        public ActionResult Edit(int? id)
        {
           SalaryStatusViewModel obj = new SalaryStatusViewModel();
            SalaryStatu s = db.SalaryStatus.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.ID = s.ID;
                obj.StaffID = s.StaffID;
                obj.SalaryID = s.SalaryID;
                obj.Status = s.Status;
               
            }
            return View(obj);
        }

        // POST: SalaryStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, SalaryStatusViewModel obj)
        {
            try
            {
                //db.Salesmen.Find(id).SalesmanID = obj.SalesmanID;
                db.SalaryStatus.Find(id).SalaryID = obj.SalaryID;
                db.SalaryStatus.Find(id).StaffID = obj.StaffID;
                db.SalaryStatus.Find(id).Status = obj.Status;
               
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: SalaryStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            SalaryStatusViewModel obj = new SalaryStatusViewModel();
            SalaryStatu s = db.SalaryStatus.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.ID = s.ID;
                obj.StaffID = s.StaffID;
                obj.SalaryID = s.SalaryID;
                obj.Status = s.Status;
                
            }
            return View(obj);
        }

        // POST: SalaryStatus/Delete/5
        
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, SalaryStatusViewModel obj)
        {
            try
            {
                var v = db.SalaryStatus.Where(a => a.ID == id).First();
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
