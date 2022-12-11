using UpSchool_CQRS_DesignPatterns.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers
{
    public class GetProductHumanResourcesByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResourcesByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductHumanResourceByIDQueryResult Handle(GetProductHumanResourceByIDQuery query)
        {
            //Bu gelecek değerleri tutan GetProductHumanResourceByIDQueryResult türünde
            //metod olacak ama parametre olarak id'yi içeren query sınıfını alacak
            var values = _productContext.Products.Find(query.Id);
            return new GetProductHumanResourceByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice
            };
        }
    }
}
