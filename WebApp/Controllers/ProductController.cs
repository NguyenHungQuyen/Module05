namespace WebApp.Controllers
{
    public class ProductController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            return View(await Provider.Product.GetProductsAsync());
        }
    }
}
