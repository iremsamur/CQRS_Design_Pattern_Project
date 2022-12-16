using MediatR;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands
{
    //silme işlemi 
    public class RemoveUniversityCommand : IRequest
    {
        public int id { get; set; }

        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }
    }
}
