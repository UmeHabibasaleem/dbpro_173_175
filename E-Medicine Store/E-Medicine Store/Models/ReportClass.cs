using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Medicine_Store.Models
{
    
    public class ReportClass
    {
        public int OwnerId { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public DateTime Date { get; set; }
        public static List<string> Categories = new List<string>();
        public void CategoriesName()
        {
            DB5Entities5 db2 = new DB5Entities5();
            List<Category> list = db2.Categories.ToList();
            foreach (Category c in list )
            {
                Categories.Add(c.Name);
            }
        }


    }
}