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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual ObjectResult<AllStaffs_Result> AllStaffs(Nullable<int> ownerId)
        {
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllStaffs_Result>("AllStaffs", ownerIdParameter);
        }
    
        public virtual ObjectResult<CategoryWiseMedicine_Result> CategoryWiseMedicine(Nullable<int> ownerId, string categoryName)
        {
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(int));
    
            var categoryNameParameter = categoryName != null ?
                new ObjectParameter("CategoryName", categoryName) :
                new ObjectParameter("CategoryName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CategoryWiseMedicine_Result>("CategoryWiseMedicine", ownerIdParameter, categoryNameParameter);
        }
    
        public virtual ObjectResult<CompanyWiseStock_Result> CompanyWiseStock(string companyName, Nullable<int> ownerID)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var ownerIDParameter = ownerID.HasValue ?
                new ObjectParameter("OwnerID", ownerID) :
                new ObjectParameter("OwnerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CompanyWiseStock_Result>("CompanyWiseStock", companyNameParameter, ownerIDParameter);
        }
    
        public virtual ObjectResult<MonthlySalaryReport_Result> MonthlySalaryReport(Nullable<System.DateTime> salaryMonth, Nullable<int> ownerId)
        {
            var salaryMonthParameter = salaryMonth.HasValue ?
                new ObjectParameter("SalaryMonth", salaryMonth) :
                new ObjectParameter("SalaryMonth", typeof(System.DateTime));
    
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MonthlySalaryReport_Result>("MonthlySalaryReport", salaryMonthParameter, ownerIdParameter);
        }
    
        public virtual ObjectResult<PostedStaffs_Result> PostedStaffs(Nullable<int> ownerId, string post)
        {
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(int));
    
            var postParameter = post != null ?
                new ObjectParameter("post", post) :
                new ObjectParameter("post", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PostedStaffs_Result>("PostedStaffs", ownerIdParameter, postParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
