using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Medicine_Store.Models
{
    public class SalesmanViewModel
    {
        public int SalesmanID { get; set; }
        [Required]
        [Display(Name = "Salesman Name")]
        [StringLength(50, ErrorMessage = "The length of name should be with in 50")]
        public string Name { get; set; }
        public string CNIC { get; set; }
        [StringLength(14, ErrorMessage = "The length of CNIC should be with in 14")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
       
        [Required]
        [Display(Name = "Company")]
        public int CompanyID { get; set; }

        public int StockID { get; set; }

        //public IEnumerable<SelectListItem>CompanyList { get; set; }
         //[NotMapped]

        public  List<Comapny> CompanyCollection { get; set; }
        /*[Required]
        [Display(Name = "Stock Name")]
        public string  StockName { get; set; }*/
    }
}