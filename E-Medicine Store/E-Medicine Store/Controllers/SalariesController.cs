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
    public class SalariesController : Controller
    {
        private DB5Entities5 db = new DB5Entities5();

        // GET: Salaries
        public ActionResult Index()
        {
            try
            {
                List<Salary> list = db.Salaries.ToList();
                List<SalaryViewModel> viewList = new List<SalaryViewModel>();
                foreach (Salary s in list)
                {
                    SalaryViewModel obj = new SalaryViewModel();
                    obj.SalaryId = s.SalaryId;
                    obj.Scale = s.Scale;
                    obj.SalaryAmount = s.SalaryAmount;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Salaries/Details/5
        public ActionResult Details(int? id)
        {
            SalaryViewModel obj = new SalaryViewModel();
            Salary s = db.Salaries.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalaryId = s.SalaryId;
                obj.Scale = s.Scale;
                obj.SalaryAmount = s.SalaryAmount;
            }
            return View(obj);
        }

        // GET: Salaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salaries/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SalaryViewModel obj)
        {
            try
            {
                Salary  s = new Salary();
                s.Scale = obj.Scale;
                s.SalaryAmount = obj.SalaryAmount;
                db.Salaries.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Salaries/Edit/5
        public ActionResult Edit(int? id)
        {
            SalaryViewModel obj = new SalaryViewModel();
            Salary s = db.Salaries.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalaryId = s.SalaryId;
                obj.Scale = s.Scale;
                obj.SalaryAmount = s.SalaryAmount;
            }
            return View(obj);
        }

        // POST: Salaries/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, SalaryViewModel obj)
        {
            try
            {
                db.Salaries.Find(id).Scale = obj.Scale;
                db.Salaries.Find(id).SalaryAmount = obj.SalaryAmount;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Salaries/Delete/5
        public ActionResult Delete(int? id)
        {
            SalaryViewModel obj = new SalaryViewModel();
            Salary s = db.Salaries.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.SalaryId = s.SalaryId;
                obj.Scale = s.Scale;
                obj.SalaryAmount = s.SalaryAmount;
            }
            return View(obj);
        }

        // POST: Salaries/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, SalaryViewModel obj)
        {
            try
            {
                var v = db.Salaries.Where(a => a.SalaryId== id).First();
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
