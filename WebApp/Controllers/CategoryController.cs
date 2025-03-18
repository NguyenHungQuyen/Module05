using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class CategoryController : BaseController
{
    public async Task<IActionResult> Index()
    {
        return View(await Provider.Category.GetCategoriesAsync());
    }
}
