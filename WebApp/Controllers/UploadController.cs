using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers

    public class UploadController : BaseController
    {
        IConfiguration configuration;

        public UploadController(IConfiguration configuration) => this.configuration = configuration;

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile f)
        {
            if (f is null)
            {
                return View();
            }

            Uri uri = new Uri(configuration["ApiUrl"] ?? throw new Exception("Not found ApiUrl"));
            using (HttpClient client = new HttpClient { BaseAddress = uri })
            {
                MultipartFormDataContent content = new MultipartFormDataContent();
                content.Add(new StreamContent(f.OpenReadStream()), "f", f.FileName);
                HttpResponseMessage message = await client.PostAsync("/api/upload", content);
                if (message.IsSuccessStatusCode)
                {
                    return View(model: await message.Content.ReadAsStringAsync());
                }
            }
            return View();
        }
    }
