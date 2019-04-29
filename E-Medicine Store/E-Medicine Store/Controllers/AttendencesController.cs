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
       private DB5Entities5 db = new DB5Entities5();

        // GET: Attendences
        public ActionResult Index()
        {
            try
            {
                List<Attendence> list = db.Attendences.ToList();
                List<AttendenceViewModel> viewList = new List<AttendenceViewModel>();
                foreach (Attendence A in list)
                {
                    AttendenceViewModel obj = new AttendenceViewModel();
                    obj.AttendenceID = A.AttendenceID;
                    obj.Date = A.Date;
                    obj.Status= A.Status;
                    obj.StaffID = A.StaffID;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Attendences/Details/5
        public ActionResult Details(int? id)
        {
            AttendenceViewModel obj = new AttendenceViewModel();
            Attendence A = db.Attendences.Find(id);
            if (A == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.AttendenceID = A.AttendenceID;
                obj.Date = A.Date;
                obj.Status = A.Status;
                obj.StaffID = A.StaffID;
            }
            return View(obj);
        }
        // GET: Attendences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attendences/Create
       
        [HttpPost]
        public ActionResult Create(int id, AttendenceViewModel obj)
        {
            try
            {
                Attendence Att = new Attendence();
                Att.Date = obj.Date;
                Att.Status = obj.Status.ToString();
                Att.StaffID = id;
                db.Attendences.Add(Att);
                db.SaveChanges();
                // return RedirectToAction("Index");
                ViewBag.Message = "Attendence has been Marked ";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       



        // GET: Attendences/Edit/5
        public ActionResult Edit(int? id)
        {
            AttendenceViewModel obj = new AttendenceViewModel();
            Attendence A = db.Attendences.Find(id);
            if (A == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.AttendenceID = A.AttendenceID;
                obj.Date = A.Date;
                obj.Status = A.Status;
                obj.StaffID = A.StaffID;
            }
            return View(obj);
        }

        // POST: Attendences/Edit/5
        
        [HttpPost]

        public ActionResult Edit(int? id, AttendenceViewModel obj)
        {
            try
            {
                db.Attendences.Find(id).Date = obj.Date;
                db.Attendences.Find(id).Status = obj.Status;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendences/Delete/5
        public ActionResult Delete(int? id)
        {
            AttendenceViewModel obj = new AttendenceViewModel();
            Attendence A = db.Attendences.Find(id);
            if (A == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.AttendenceID = A.AttendenceID;
                obj.Date = A.Date;
                obj.Status = A.Status;
                obj.StaffID = A.StaffID;
            }
            return View(obj);
        }

        // POST: Attendences/Delete/5
        [HttpPost, ActionName("Delete")]

        public ActionResult Delete(int? id, AttendenceViewModel obj)
        {
            try
            {
                // TODO: Add insert logic here

                var v = db.Attendences.Where(a => a.AttendenceID == id).First();
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
