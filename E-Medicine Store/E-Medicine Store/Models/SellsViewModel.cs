using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Medicine_Store.Models
{
    public class SellsViewModel
    {
        public int SellId { get; set; }
        public int MedId { get; set; }
        public List<Medicine> MedicineCollection { get; set; }
        public int Price { get; set; }

        public int StaffId { get; set; }
        public List<Staff> StaffData{ get; set; }
        public string CustomerName { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public System.DateTime Date { get; set; }

    }
}