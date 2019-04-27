using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Medicine_Store.Models;

namespace E_Medicine_Store.Controllers
{
    public class HomeController : Controller
    {
        DB5Entities3 db = new DB5Entities3();
        public ActionResult Index()
        {
            return View();
        }

        //Get
      
        [AllowAnonymous]
        public ActionResult Registeration()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Registeration(Registration obj)
        {
            try
            {
                ShopOwner s = new ShopOwner();
                MedicalStore Ms = new MedicalStore();
                Ms.ShopName = obj.ShopName;
                Ms.ShopAddress = obj.ShopAddress;
                db.MedicalStores.Add(Ms);
                
                db.SaveChanges();
                s.Name = obj.Name;
                s.CNIC = obj.CNIC;
                s.Confirm_Password = obj.Confirm_Password;
                s.Email = obj.Email;
                s.ShopId = Ms.ShopId;
                s.OwnerId = Ms.ShopId;
                db.ShopOwners.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
           return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            var result1 = (from emp in db.ShopOwners where emp.Email == model.Email select emp.Confirm_Password).FirstOrDefault();


            if (result1 == model.Password)

            {
                var result = (from emp in db.ShopOwners where emp.Email == model.Email select emp.OwnerId).FirstOrDefault();
                Session["OwnerId"] = result;
                return RedirectToAction("OwnerProfile", "Home", new { id = result });

            }

            else

            {

                ViewBag.Message = string.Format("UserName and Password is incorrect");

                return View();

            }
        }
        public ActionResult OwnerProfile(int ? id)
        {
            Registration obj = new Registration();
            ShopOwner s = db.ShopOwners.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.Name = s.Name;
                obj.CNIC = s.CNIC;
                obj.Email = s.Email;
                obj.ShopId = s.ShopId;
                obj.Confirm_Password = s.Confirm_Password;
                MedicalStore Ms = db.MedicalStores.Find(obj.ShopId);
                obj.ShopName = Ms.ShopName;
                obj.ShopAddress = Ms.ShopAddress;
                obj.OwnerId = s.OwnerId;
            }
            return View(obj);

        }
        // GET: Person/Edit/5
        public ActionResult Edit(int? id)
        {
            Registration obj = new Registration();
            ShopOwner s = db.ShopOwners.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            else
            {
                obj.OwnerId = s.OwnerId;
                obj.Name = s.Name;
                obj.CNIC = s.CNIC;
                obj.Email = s.Email;
                obj.ShopId = s.ShopId;
                obj.Confirm_Password = s.Confirm_Password;
                MedicalStore Ms = db.MedicalStores.Find(obj.ShopId);
                obj.ShopName = Ms.ShopName;
                obj.ShopAddress = Ms.ShopAddress;
            }
            return View(obj);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Registration obj)
        {
            try
            {
                // TODO: Add insert logic here
                
                db.ShopOwners.Find(id).Name = obj.Name;
                db.ShopOwners.Find(id).CNIC = obj.CNIC;
                db.ShopOwners.Find(id).Confirm_Password = obj.Confirm_Password;
                db.ShopOwners.Find(id).Email = obj.Email;
                db.MedicalStores.Find(id).ShopName = obj.ShopName;
                db.MedicalStores.Find(id).ShopAddress = obj.ShopAddress;
                db.SaveChanges();
                return RedirectToAction("OwnerProfile", "Home", new { id = id });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult StaffLogin()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult StaffLogin(LoginModel model)
        {
            var result1 = (from emp in db.Staffs where emp.Email == model.Email select emp.Password).FirstOrDefault();


            if (result1 == model.Password)

            {
                var result = (from emp in db.Staffs where emp.Email == model.Email select emp.OwnerId).FirstOrDefault();
                var StaffId = (from emp in db.Staffs where emp.Email == model.Email select emp.StaffID).FirstOrDefault();
                Session["OwnerId"] = result;
                Session["StaffId"] = StaffId;
                return RedirectToAction("OwnerProfile", "Home", new { id = result });

            }

            else

            {

                ViewBag.Message = string.Format("UserName and Password is incorrect");

                return View();

            }
        }

    }
}