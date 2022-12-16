using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_DesignPatterns.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler : IRequestHandler<GetUniversityByIDQuery, GetUniversityByIDQueryResult>
    {
        private readonly ProductContext _context;

        public GetUniversityByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.id);
            //id'ye göre listeleme için query içindeki id'ye ulaşmalı
            //bu id'yede mediatr'den hazır otomatik gelen handle metodu içindeki
            //request parametresinden ulaşılır.
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,

                City = values.City,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}
