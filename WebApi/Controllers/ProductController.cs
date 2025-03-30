using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        public IEnumerable<Product> GetProducts()
        {
            return Provider.Product.GetProducts();
        }

        [HttpPost]
        public int Add(Product obj)
        {
            return Provider.Product.Add(obj);
        }
        [HttpGet("{page}/{size}")]
        public IEnumerable<Product> GetProducts(int page, int size = 10)
        {
            return Provider.Product.GetProducts(page, size);
        }
        [HttpGet("count")]
        public int Count()
        {
            return Provider.Product.Count();
        }
         [HttpGet("all/{page}/{size?}")]
        public object GetProductsAnd(int page, int size = 10)
        {
            return new {
                Products=Provider.Product.GetProducts(page, size),
                Count=Provider.Product.Count()
            } ;
        }
    }
}
