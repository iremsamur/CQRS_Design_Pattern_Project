namespace UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults
{
    public class GetProductStoragerQueryResult
    {
        //Depocunun göreceği alanlar 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
    }
}
