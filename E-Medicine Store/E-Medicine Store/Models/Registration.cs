using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E_Medicine_Store.Models
{
    public class Registration
    {
            public int OwnerId { get; set; }
            [Required]
            [Display(Name = "OwnerName")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "CNIC")]
            [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
            public string CNIC { get; set; }
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Confirm_Password { get; set; }

           
            [Display(Name = "ShopId")]
            public int ShopId { get; set; }
            [Required]
            [Display(Name = "ShopName")]
            public string ShopName { get; set; }
            [Required]
            [Display(Name = "ShopAddress")]
            public string ShopAddress { get; set; }


    }
    public class LoginModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}