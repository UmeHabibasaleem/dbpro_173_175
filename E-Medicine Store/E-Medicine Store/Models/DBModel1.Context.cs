﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB5Entities5 : DbContext
    {
        public DB5Entities5()
            : base("name=DB5Entities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comapny> Comapnies { get; set; }
        public virtual DbSet<MedicalStore> MedicalStores { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SalaryStatu> SalaryStatus { get; set; }
        public virtual DbSet<Salesman> Salesmen { get; set; }
        public virtual DbSet<Sell> Sells { get; set; }
        public virtual DbSet<ShopOwner> ShopOwners { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
