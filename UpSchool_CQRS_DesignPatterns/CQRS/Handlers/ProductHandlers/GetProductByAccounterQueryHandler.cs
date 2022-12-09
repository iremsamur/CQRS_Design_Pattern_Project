using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_DesignPatterns.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers
{
    public class GetProductByAccounterQueryHandler
    {
        //handler sınıfında işlemler yazılacak
        private readonly ProductContext _productContext;

        public GetProductByAccounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        //sadece muhasebecinin göreceği ekranın bulunduğu kısım işlemleri buraya yazılacak
        //Bu product'ın listlemesi için hangi DTO'yu yazdıysak onu alacak ve ona göre
        //listeleme yapılacak
        public List<GetProductByAccounterQueryResult> Handle()
        {
            //sonucun döneceği modelden sadece hangi  veriler listelenecekse  o gelecek
            //verileri tutan Result sınıfı DTO 
            var values = _productContext.Products.Select(x => new GetProductByAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice

            }).AsNoTracking().ToList(); //AsTracking performansu arttırmayı sağlayan method
            return values;
        }

    }
}
