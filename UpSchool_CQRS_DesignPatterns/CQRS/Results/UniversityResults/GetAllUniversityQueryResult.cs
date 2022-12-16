namespace UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults
{
    public class GetAllUniversityQueryResult
    {
        //üniversite ile ilgili
        //sadece şu bilgiler olsun
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
    }
}
