using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers;
using UpSchool_CQRS_DesignPatterns.CQRS.Handlers.StudentHandlers;
using UpSchool_CQRS_DesignPatterns.CQRS.Queries.StudentQueries;

namespace UpSchool_CQRS_DesignPatterns.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentHandler = removeStudentHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }
        public IActionResult GetAllStudents()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand createStudentCommand)
        {
            _createStudentCommandHandler.Handle(createStudentCommand);
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult DeleteStudent(int id)
        {
            _removeStudentHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("GetAllStudents");
        }
        //güncelleme için önce id'ye göre güncellenecek olanın id'sini alıp o değeri buluruz.
        //listeleme yazarız.
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(new GetStudentByIDQuery(id));
            return View(values);
            
        }
        //güncelleme işlemi
        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("GetAllStudents");

        }
    }
}
