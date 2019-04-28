using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Medicine_Store.Models
{
    public class MedicineViewModel
    {
        public int MedID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Measurement { get; set; }
        public int Price { get; set; }
        public int StockID { get; set; }
        public List<Stock> StockCollection { get; set; }
        public int CategoryID { get; set; }

        public List<Category> CategoryCollection { get; set; }
    }
}