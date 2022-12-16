using MediatR;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands
{
    public class UpdateUniversityCommand : IRequest
    {
        //güncellenecek parametreler
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }

    }
}
