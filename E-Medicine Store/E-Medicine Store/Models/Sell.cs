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
    
    public partial class Sell
    {
        public int SellId { get; set; }
        public int MedId { get; set; }
        public int Price { get; set; }
        public int StaffId { get; set; }
        public string CustomerName { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
