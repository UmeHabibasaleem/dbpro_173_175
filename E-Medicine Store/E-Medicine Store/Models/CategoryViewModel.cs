using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [StringLength(50, ErrorMessage = "The length of name should be with in 50")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "The length of Type should be with in 50")]
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}