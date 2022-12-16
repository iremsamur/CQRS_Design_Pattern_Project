namespace UpSchool_CQRS_DesignPatterns.DAL.Entities
{
    public class University
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
        public string DepartmentCount { get; set; }
        public string Country { get; set; }
    }
}
