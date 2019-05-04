using E_Medicine_Store.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Medicine_Store.Controllers
{
    public class StaffReportController : Controller
    {
        // GET: StaffReport
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StaffData()
        {

            var Ownerid = (int)Session["OwnerId"];
            using (var context = new DB5Entities5())
            {
                var courses = context.AllStaffs(Ownerid).ToList();
               StaffRecords rpt = new StaffRecords();
                rpt.Load();
                rpt.SetDataSource(courses);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");


            }
            
        }
    }
}