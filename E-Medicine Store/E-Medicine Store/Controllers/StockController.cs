using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;
using System.Data.Entity;

namespace E_Medicine_Store.Controllers
{
    public class StockController : Controller
    {
        DB5Entities5 db = new DB5Entities5();
        // GET: Stock
        public ActionResult Index()
        {
            var id = (int)Session["OwnerId"];
            List<Stock> list = db.Stocks.ToList();
            List<StockViewModel> viewList = new List<StockViewModel>();
            foreach (Stock s in list)
            {
                if (s.OwnerId == id)
                {
                    StockViewModel obj = new StockViewModel();
                    obj.StockID = s.StockID;
                    obj.StockNumber = s.StockNumber;
                    obj.StockType = s.StockType;
                    obj.Stockitem = s.Stockitem;
                    obj.Description= s.Description;
                    obj.OwnerId = s.OwnerId;
                    obj.Quantity = s.Quantity;
                    viewList.Add(obj);
                }

            }
            return View(viewList);
        }

        // GET: Stock/Details/5
        public ActionResult Details(int? id)
        {
            StockViewModel obj = new StockViewModel();
            Stock s = db.Stocks.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StockID = s.StockID;
                obj.StockNumber = s.StockNumber;
                obj.StockType = s.StockType;
                obj.Stockitem = s.Stockitem;
                obj.Description = s.Description;
                obj.OwnerId = s.OwnerId;
                obj.Quantity = s.Quantity;
            }
            return View(obj);
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockViewModel obj)
        {
            var Ownerid = (int)Session["OwnerId"];
            try
            {
                Stock s = new Stock();
                s.StockNumber = obj.StockNumber;
                s.StockType = obj.StockType;
                s.Stockitem = obj.Stockitem;
                s.Description = obj.Description;
                s.OwnerId = Ownerid;
                s.Quantity = obj.Quantity;
                db.Stocks.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int? id)
        {
            StockViewModel obj = new StockViewModel();
            Stock s = db.Stocks.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StockID = s.StockID;
                obj.StockNumber = s.StockNumber;
                obj.StockType = s.StockType;
                obj.Stockitem = s.Stockitem;
                obj.Description = s.Description;
                obj.OwnerId = s.OwnerId;
                obj.Quantity = s.Quantity;
            }
            return View(obj);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, StockViewModel obj)
        {
            try
            {
                db.Stocks.Find(id).Quantity = obj.Quantity;
                db.Stocks.Find(id).Stockitem = obj.Stockitem;
                db.Stocks.Find(id).Description = obj.Description;
                db.Stocks.Find(id).StockType = obj.StockType;
                db.Stocks.Find(id).StockNumber = obj.StockNumber;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int? id)
        {
            StockViewModel obj = new StockViewModel();
            Stock s = db.Stocks.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.StockID = s.StockID;
                obj.StockNumber = s.StockNumber;
                obj.StockType = s.StockType;
                obj.Stockitem = s.Stockitem;
                obj.Description = s.Description;
                obj.OwnerId = s.OwnerId;
                obj.Quantity = s.Quantity;
            }
            return View(obj);
        }

        // POST: Stock/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, StockViewModel obj)
        {

            try
            {
                var v = db.Stocks.Where(a => a.StockID == id).First();
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
