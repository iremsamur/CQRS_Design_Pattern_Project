namespace UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults
{
    public class GetProductAccounterByIDQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Description{ get; set; }
        public int Tax { get; set; }
    }
}
