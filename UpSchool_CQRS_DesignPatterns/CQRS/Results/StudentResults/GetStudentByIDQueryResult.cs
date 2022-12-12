namespace UpSchool_CQRS_DesignPatterns.CQRS.Results.StudentResults
{
    public class GetStudentByIDQueryResult
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

    }
}
