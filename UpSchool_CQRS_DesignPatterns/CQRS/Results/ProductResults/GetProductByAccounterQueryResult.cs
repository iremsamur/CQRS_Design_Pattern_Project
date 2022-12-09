namespace UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults
{
    public class GetProductByAccounterQueryResult
    {
        //listelemeden dönecek sonuçları tutan dto sınıfı yani model 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
