using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers
{
    public class GetProductStoragerQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductStoragerQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductStoragerQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new
            GetProductStoragerQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage=x.Storage
                
               
                

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
