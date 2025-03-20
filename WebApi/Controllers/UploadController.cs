using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController, Route("api/[controller]")]
public class UploadController : BaseController
{
    [HttpPost]
    public string? Post(IFormFile f)
    {
        return Helper.Upload(f);
    }

    [HttpPost("multiple")]
    public IEnumerable<string>? Post(IFormFile[] af)
    {
        return Helper.Upload(af);
    }
}
