using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand>
    {
        //güncelleme işlemi
        private readonly ProductContext _context;

        public UpdateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.UniversityID);
            values.Name = request.Name;
            values.City = request.City;
            values.Population = request.Population;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
