using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_DesignPatterns.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.StudentResults;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.UniversityResults;

namespace UpSchool_CQRS_DesignPatterns.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IMediator _mediator;//mediator aracılığıyla query'e ulaşacağım ve verileri böylece handler sınıfını burada tanımlamak zorunda kalmadım.

        public UniversityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //query üzerindne çekiyor olacağız.

        public IActionResult Index()
        {
            return View();
        }
        //tüm verileri listeleme
        public async Task<IActionResult> GetAllUniversities()
        {
            var values = await _mediator.Send(new GetAllUniversityQuery());
            //Benim requestim Query'de olduğu için query'i parametre olarak send metoduna veriyorum.
            //Böylece verileri bana query üzerinden getirir.
            return View(values);

        }
        //güncelleme için id'ye göre o güncelleencek verinin eski bilgilerini getirme
        [HttpGet]
        public async Task<IActionResult> UpdateUniversity(int id)
        {
            var values = await _mediator.Send(new GetUniversityByIDQuery(id));
            return View(values);
        }
        //güncelleme işlemi
        [HttpPost]
        public async Task<IActionResult> UpdateUniversity(UpdateUniversityCommand command)
        {
            var values = await _mediator.Send(command);
            return RedirectToAction("GetAllUniversities");
        }
        //ekleme işlemi
        [HttpGet]
        public IActionResult AddUniversity()
        {
            return View();
        }
        //ekleme işlemi
        [HttpPost]
        public async Task<IActionResult> AddUniversity(CreateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("GetAllUniversities");

        }
        //silme
        public async Task<IActionResult> DeleteUniversity(int id)
        {
            await _mediator.Send(new RemoveUniversityCommand(id));
            return RedirectToAction("GetAllUniversities");

        }

    }
}
