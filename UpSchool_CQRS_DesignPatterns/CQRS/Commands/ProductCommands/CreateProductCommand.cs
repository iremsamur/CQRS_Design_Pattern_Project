using System;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Cost { get; set; }
        public bool Status { get; set; }
      
        public decimal Size { get; set; } //gram/kg dğeeri

        public DateTime ProduceOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
    }
}
