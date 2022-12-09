using System;

namespace UpSchool_CQRS_DesignPatterns.DAL.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Cost { get; set; }
        public string Supplier { get; set; }
        public DateTime ProduceOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
        public bool Status{ get; set; }
        public string Description { get; set; }
        public string SizeType { get; set; } //gram/kg gibi
        public decimal Size{ get; set; } //gram/kg dğeeri
    }
}
