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
    
    public partial class Salesman
    {
        public int SalesmanID { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Phone { get; set; }
        public int CompanyID { get; set; }
        public int StockID { get; set; }
    
        public virtual Comapny Comapny { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
