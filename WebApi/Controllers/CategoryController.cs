using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        [HttpGet("hello")]
        public string Hello()
        {
            return "Welcome Ladies and Gentlemen";
        }

        public IEnumerable<Category> GetCategories()
        {
            return Provider.Category.GetCategories();
        }

        [HttpGet("{id}")]
        public Category? GetCategory(short id)
        {
            return Provider.Category.GetCategory(id);
        }

        [HttpPost]
        public int Add(Category obj)
        {
            return Provider.Category.Add(obj);
        }

        [HttpDelete("{id}")]
        public int Delete(short id)
        {
            return Provider.Category.Delete(id);
        }

        [HttpPut]
        public int Edit(Category obj)
        {
            return Provider.Category.Edit(obj);
        }

        [HttpGet("count")]
        public int Count()
        {
            return Provider.Category.Count();
        }

    }
