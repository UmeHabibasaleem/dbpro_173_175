using E_Medicine_Store.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Medicine_Store.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        /*public ActionResult MYReport()
        {
          var id = (int)Session["OwnerId"];
            using (var context = new DB5Entities5())
            {
                var courses = context.CompanyRecord(id).ToList();
                CompanyRecordrpt rpt = new CompanyRecordrpt();
                rpt.Load();
                rpt.SetDataSource(courses);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
        }
        public ActionResult Attendence_Per_day()
        {
            var id = (int)Session["OwnerId"];
            DateTime Day = Convert.ToDateTime(Request["date"].ToString());
            using (var context = new DB5Entities5())
            {
                var courses = context.Attendence_Per_day(Day,id).ToList();
                AttendencePerDayReport rpt = new AttendencePerDayReport();
                rpt.Load();
                rpt.SetDataSource(courses);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
       }
        public ActionResult Attendence_Per_Month()
        {
            int Year = Convert.ToInt32(Request["MyYear"].ToString());
            int Month = Convert.ToInt32(Request["MyMonth"].ToString());
            var id = (int)Session["OwnerId"];
            using (var context = new DB5Entities5())
            {
                var Att = context.Attendence_Per_Month(Month,Year,id).ToList();
                AttendancePerMonth rpt = new AttendancePerMonth();
                rpt.Load();
                rpt.SetDataSource(Att);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
        }
        public ActionResult Medicine_sold_per_day()
        {
            var id = (int)Session["OwnerId"];
            DateTime Day = Convert.ToDateTime(Request["date"].ToString());
            using (var context = new DB5Entities5())
            {
                var courses = context.Medicine_sold_per_DAy(Day, id).ToList();
                MedicinePerDayReport rpt = new MedicinePerDayReport();
                rpt.Load();
                rpt.SetDataSource(courses);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
        }
        public ActionResult Medicine_sold_per_Month()
        {
            int Year = Convert.ToInt32(Request["MyYear"].ToString());
            int Month = Convert.ToInt32(Request["MyMonth"].ToString());
            var id = (int)Session["OwnerId"];
            using (var context = new DB5Entities5())
            {
                var Att = context.Medicine_sold_per_Month(Year, Month, id).ToList();
                MedicineSoldPerMonth rpt = new MedicineSoldPerMonth();
                rpt.Load();
                rpt.SetDataSource(Att);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
        }*/
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

       /* public ActionResult StaffPosted()
        {
            int Year = Convert.ToInt32(Request["MyYear"].ToString());
            int Month = Convert.ToInt32(Request["MyMonth"].ToString());
            var id = (int)Session["OwnerId"];
            using (var context = new DB5Entities5())
            {
                var Att = context.Attendence_Per_Month(Month, Year, id).ToList();
                AttendancePerMonth rpt = new AttendancePerMonth();
                rpt.Load();
                rpt.SetDataSource(Att);
                Stream s = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                return File(s, "application/pdf");
            }
        }*/
    }
}