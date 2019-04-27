using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class SalaryViewModel
    {
        public int SalaryId { get; set; }
        [Required]
        [Display(Name = "Scale")]
        public int Scale { get; set; }
        [Required]
        [Display(Name = "Salary Amount")]
        public int SalaryAmount { get; set; }
    }
}