using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers;

namespace UpSchool_CQRS_DesignPatterns.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductByAccounterQueryHandler _getProductByAccounterQueryHandler;
        private readonly GetProductStoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourcesByIDQueryHandler _getHumanResourcesByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;




        public ProductController(GetProductByAccounterQueryHandler getProductByAccounterQueryHandler, GetProductStoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourcesByIDQueryHandler getHumanResourcesByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler)
        {
            _getProductByAccounterQueryHandler = getProductByAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getHumanResourcesByIDQueryHandler = getHumanResourcesByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductByAccounterQueryHandler.Handle();
            return View(values);
        }
        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }
        public IActionResult GetHumanResourcesIndex(int id)
        {
            var values = _getHumanResourcesByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductHumanResourceByIDQuery(id));//id'yi burada kullanabilmek için constructor içinde yazdık
            return View(values);
        }

        //id'ye göre muhaebecinin verileri getirilsin.
        public IActionResult GetAccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductAccounterByIDQuery(id));//id'yi burada kullanabilmek için constructor içinde yazdık
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
