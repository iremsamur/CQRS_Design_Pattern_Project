using MediatR;
using System.Collections.Generic;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.StudentResults;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery : IRequest<List<GetAllUniversityQueryResult>>
        //Bu parametre olarak istediğimiz verileri listelemek için Results'ı alır.
        //Yani List türünde GetAllUniversityResult olur.
        //List olmasa sadece GetAllStudentQueryResult olurdu.
    {

    }
}
