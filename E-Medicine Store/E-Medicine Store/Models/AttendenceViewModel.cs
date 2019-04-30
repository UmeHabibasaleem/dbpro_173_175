using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class AttendenceViewModel
    {
        public int AttendenceID { get; set; }
        public int StaffID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime Date { get; set; }
        public string Status { get; set; }

    }

}