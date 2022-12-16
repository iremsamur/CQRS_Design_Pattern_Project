using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_DesignPatterns.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults;
using UpSchool_CQRS_DesignPatterns.DAL.Context;
using UpSchool_CQRS_DesignPatterns.DAL.Entities;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler : IRequestHandler<GetAllUniversityQuery,List<GetAllUniversityQueryResult>> //Bu mediatr'den hazır 
        //metodları alıp kullanabilmek için içine parametreler için query'i
        //ve dönecek sonuçları tutmak için Result'ı veririrm.
    {
        private readonly ProductContext _productContext;

        public GetAllUniversityQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _productContext.Universities.Select(x =>
            new GetAllUniversityQueryResult
            {
                    UniversityID=x.UniversityID,
                    Town=x.City,
                    Name=x.Name

            }).AsNoTracking().ToListAsync();
        }
        //handle metodunu yazmak yerini MediaTR kullanarak miras alınacak

    }
}
