using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class CompnayViewModel
    {
        public int CompanyID { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        [StringLength(50,ErrorMessage ="The length of name should be with in 50")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }
        [Required]
        [Display(Name = "Company Type")]
        public string CompanyType { get; set; }
    }
}