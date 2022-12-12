using UpSchool_CQRS_DesignPatterns.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_DesignPatterns.DAL.Context;
using UpSchool_CQRS_DesignPatterns.DAL.Entities;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _context = productContext;
        }

        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.Name,
                Surname = command.Surname,
                Age = command.Age,
                City = command.City,
                Status = false

            });
            _context.SaveChanges();
            
        }
    }

    
}
