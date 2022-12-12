namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
        public int Age { get; set; }
    }
}
