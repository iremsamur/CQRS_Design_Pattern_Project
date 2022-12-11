using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_DesignPatterns.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_DesignPatterns.DAL.Context;
using UpSchool_CQRS_DesignPatterns.DAL.Entities;

namespace UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                //ekleme işleminde veritabanındaki entity'e ekleme yapılacağı
                //için new'e entity adı Product verilecek
                //karşısınada eklenecek değerleri parametreleri tutan 
                //Command sınıfı verilecek
                Brand = command.Brand,
                Cost = command.Cost,
                Stock=command.Stock,
                Tax=command.Tax,
                PurchasePrice=command.PurchasePrice,
                SalePrice=command.SalePrice,
                Name=command.Name,
                Size=command.Size,
                ProduceOfDate=command.ProduceOfDate,
                EndOfDate=command.EndOfDate,
                Status=true

            });
            _productContext.SaveChanges();
                

        }
    }
}
