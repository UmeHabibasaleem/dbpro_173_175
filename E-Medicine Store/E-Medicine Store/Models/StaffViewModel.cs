using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Medicine_Store.Models
{
    public class StaffViewModel
    {
        public int StaffID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public System.DateTime Join_Date { get; set; }
        [Required]
        public string Post { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "CNIC")]
        [StringLength(13, ErrorMessage = "The length of CNIC should be 13",MinimumLength = 13)]
        public string CNIC { get; set; }
        [Required]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        [EmailAddress]
        [Index(IsUnique = true)]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}