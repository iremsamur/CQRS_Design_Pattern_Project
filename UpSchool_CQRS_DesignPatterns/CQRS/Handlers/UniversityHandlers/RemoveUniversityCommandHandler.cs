using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.UniversityHandlers
{
    public class RemoveUniversityCommandHandler:IRequestHandler<RemoveUniversityCommand>
    {
        //silme
        private readonly ProductContext _context;

        public RemoveUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.id);//silinecek verileri bul
            _context.Universities.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
