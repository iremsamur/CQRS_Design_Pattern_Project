using MediatR;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand : IRequest
    {//güncelleencek verileri tutan sınıf request karşılığı mediatrde
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
    }
}
