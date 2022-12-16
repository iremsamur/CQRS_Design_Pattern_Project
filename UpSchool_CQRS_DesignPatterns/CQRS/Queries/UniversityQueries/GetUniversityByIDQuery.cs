using MediatR;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults;


namespace UpSchool_CQRS_DesignPatterns.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery : IRequest<GetUniversityByIDQueryResult>
    {
        //bu kez request sonucu bir tane bilgi geleceği için
        //liste olmayacağı için list vermiyoruz sadece class oluyor
        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }

    }
}
