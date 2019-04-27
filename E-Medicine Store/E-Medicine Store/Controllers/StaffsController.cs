using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;
using Microsoft.AspNet.Identity;

namespace E_Medicine_Store
{
    public class StaffsController : Controller
    {
        DB5Entities3 db = new DB5Entities3();
        // GET: Staffs
        public ActionResult Index()
        {
            var id = (int)Session["OwnerId"];
            List<Staff> list = db.Staffs.ToList();
            List<StaffViewModel> viewList = new List<StaffViewModel>();
            foreach (Staff s in list)
            {
               if (s.OwnerId == id)
                {
                    StaffViewModel obj = new StaffViewModel();
                    obj.StaffID = s.StaffID;
                    obj.FirstName = s.FirstName;
                    obj.LastName = s.LastName;
                    obj.DateOfBirth = s.DateOfBirth;
                    obj.Join_Date = s.Join_Date;
                    obj.OwnerId = s.OwnerId;
                    obj.Post = s.Post;
                    obj.CNIC = s.CNIC;
                    viewList.Add(obj);
                }

            }
            return View(viewList);

        }

        // GET: Staffs/Details/5
        public ActionResult Details(int? id)
        {
            StaffViewModel obj = new StaffViewModel();
            Staff s = db.Staffs.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StaffID = s.StaffID;
                obj.FirstName = s.FirstName;
                obj.LastName = s.LastName;
                obj.DateOfBirth = s.DateOfBirth;
                obj.Join_Date = s.Join_Date;
                obj.OwnerId = s.OwnerId;
                obj.Post = s.Post;
                obj.CNIC = s.CNIC;
                
            }
            return View(obj);
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staffs/Create
        
        [HttpPost]

        public ActionResult Create(StaffViewModel obj)
        {
            var Ownerid = (int)Session["OwnerId"];
            try
            {
                Staff s = new Staff();
                s.FirstName = obj.FirstName;
                s.LastName = obj.LastName;
                s.DateOfBirth = obj.DateOfBirth;
                s.Join_Date = obj.Join_Date;
                s.OwnerId = Ownerid;
                s.Post = obj.Post;
                s.CNIC = obj.CNIC;
                db.Staffs.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        // GET: Staffs/Edit/5
        public ActionResult Edit(int? id)
        {
            StaffViewModel obj = new StaffViewModel();
            Staff s = db.Staffs.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StaffID = s.StaffID;
                obj.FirstName = s.FirstName;
                obj.LastName = s.LastName;
                obj.DateOfBirth = s.DateOfBirth;
                obj.Join_Date = s.Join_Date;
                obj.OwnerId = s.OwnerId;
                obj.Post = s.Post;
                obj.CNIC = s.CNIC;

            }
            return View(obj);
        }
        // POST: Staffs/Edit/5
       
        [HttpPost]
        public ActionResult Edit(int? id, StaffViewModel obj)
        {
            try
            {
                db.Staffs.Find(id).FirstName = obj.FirstName;
                db.Staffs.Find(id).LastName = obj.LastName;
                db.Staffs.Find(id).Join_Date = obj.Join_Date;
                db.Staffs.Find(id).Post = obj.Post;
                db.Staffs.Find(id).DateOfBirth = obj.DateOfBirth;
                db.Staffs.Find(id).CNIC = obj.CNIC;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staffs/Delete/5
        public ActionResult Delete(int? id)
        {
            StaffViewModel obj = new StaffViewModel();
            Staff s = db.Staffs.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StaffID = s.StaffID;
                obj.FirstName = s.FirstName;
                obj.LastName = s.LastName;
                obj.DateOfBirth = s.DateOfBirth;
                obj.Join_Date = s.Join_Date;
                obj.OwnerId = s.OwnerId;
                obj.Post = s.Post;
                obj.CNIC = s.CNIC;

            }
            return View(obj);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, StaffViewModel obj)
        {
            try
            {
                var v = db.Staffs.Where(a => a.StaffID == id).First();
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
