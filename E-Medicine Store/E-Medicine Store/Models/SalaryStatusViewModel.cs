using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Medicine_Store.Models
{
    public class SalaryStatusViewModel
    {
        public int ID { get; set; }
        public int SalaryID { get; set; }
        public List<Salary> SalaryCollection { get; set; }
        public int StaffID { get; set; }
        public List<Staff> StaffCollection { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime PaidDate { get; set; }
    }
}