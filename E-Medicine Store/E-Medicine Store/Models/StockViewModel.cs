using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class StockViewModel
    {

        public int StockID { get; set; }
       
        [Display(Name = "Stock Number")]
        public int StockNumber { get; set; }
        [Required]
        [Display(Name = " Stock item")]
        [StringLength(50, ErrorMessage = "The length of Stockitem should be with in 50")]
        public string Stockitem { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        [Display(Name = "Stock Type")]
        [StringLength(50, ErrorMessage = "The length of StockType should be with in 50")]
        public string StockType { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public int OwnerId { get; set; }
    }
}