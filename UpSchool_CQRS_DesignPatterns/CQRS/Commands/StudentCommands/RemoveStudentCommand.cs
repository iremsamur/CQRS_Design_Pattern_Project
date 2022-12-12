namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.StudentCommands
{
    public class RemoveStudentCommand
    {
        public int id { get; set; }

        public RemoveStudentCommand(int id)
        {
            this.id = id;
        }
    }
}
