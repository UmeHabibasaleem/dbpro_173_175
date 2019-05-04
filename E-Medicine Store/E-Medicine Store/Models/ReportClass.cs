using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Medicine_Store.Models
{
    public class ReportClass
    {
        public int OwnerId { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public DateTime Date { get; set; }
    }
}