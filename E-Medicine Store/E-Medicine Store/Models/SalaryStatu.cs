//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Medicine_Store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalaryStatu
    {
        public string ID { get; set; }
        public Nullable<int> SalaryID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public string Status { get; set; }
    
        public virtual Salary Salary { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
