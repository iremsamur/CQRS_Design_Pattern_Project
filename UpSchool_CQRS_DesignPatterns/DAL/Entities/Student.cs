namespace UpSchool_CQRS_DesignPatterns.DAL.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Faculty{ get; set; }
        public string Mail { get; set; }
        public bool Status { get; set; }
        public int Age { get; set; }

    }
}
