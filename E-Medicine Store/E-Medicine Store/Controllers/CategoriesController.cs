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
    public class CategoriesController : Controller
    {
        private DB5Entities5 db = new DB5Entities5();

        // GET: Categories
        public ActionResult Index()
        {
            try
            {
                List<Category> list = db.Categories.ToList();
                List<CategoryViewModel> viewList = new List<CategoryViewModel>();
                foreach (Category C in list)
                {
                    CategoryViewModel obj = new CategoryViewModel();
                    obj.CategoryID= C.CategoryID;
                    obj.Name = C.Name;
                    obj.Type = C.Type;
                    obj.Description= C.Description;
                    viewList.Add(obj);
                }
                return View(viewList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            CategoryViewModel obj = new CategoryViewModel();
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.CategoryID = c.CategoryID;
                obj.Name = c.Name;
                obj.Type = c.Type;
                obj.Description = c.Description;
            }
            return View(obj);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
      
        [HttpPost]
        public ActionResult Create(CategoryViewModel obj)
        {
            try
            {
                Category C1 = new Category();
                C1.Name = obj.Name;
                C1.Type = obj.Type;
                C1.Description = obj.Description;
                db.Categories.Add(C1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            CategoryViewModel obj = new CategoryViewModel();
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.CategoryID = c.CategoryID;
                obj.Name = c.Name;
                obj.Type = c.Type;
                obj.Description = c.Description;
            }
            return View(obj);
        }

        // POST: Categories/Edit/5

        [HttpPost]
        public ActionResult Edit(int? id, CategoryViewModel obj)
        {
            try
            {
                db.Categories.Find(id).Name = obj.Name;
                db.Categories.Find(id).Type = obj.Type;
                db.Categories.Find(id).Description = obj.Description;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            CategoryViewModel obj = new CategoryViewModel();
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.CategoryID = c.CategoryID;
                obj.Name = c.Name;
                obj.Type = c.Type;
                obj.Description = c.Description;
            }
            return View(obj);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int? id, CategoryViewModel obj)
        {
            try
            {
                var v = db.Categories.Where(a => a.CategoryID == id).First();
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
