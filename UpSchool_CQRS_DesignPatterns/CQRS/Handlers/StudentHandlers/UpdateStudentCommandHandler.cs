using UpSchool_CQRS_DesignPatterns.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.City = command.City;
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.Age = command.Age;
            _context.SaveChanges();
        }
    }
}
