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
        [HttpGet("{page}")]
        public IEnumerable<Product> GetProducts(int page, int size = 10)
        {
            return Provider.Product.GetProducts(page, size);
        }
    }
}
