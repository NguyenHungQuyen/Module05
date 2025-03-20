using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Services;

[ApiController, Route("api/[controller]")]
public class UploadController : BaseController
{
    [HttpPost]
    public string? Post(IFormFile f)
    {
        if (f == null)
        {
            return null;
        }

        string ext = Path.GetExtension(f.FileName);
        string fileName = Helper.RandomString(32 - ext.Length) + ext;
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

        using (Stream stream = new FileStream(path, FileMode.Create))
        {
            f.CopyTo(stream);
        }

        return fileName;
    }

    [HttpPost("multiple")]
    public IEnumerable<string>? Post(IFormFile[] af)
    {
        if (af is null)
        {
            return null;
        }

        string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
        List<string> list = new List<string>(af.Length);

        foreach (var f in af)
        {
            string ext = Path.GetExtension(f.FileName);
            string fileName = Helper.RandomString(32 - ext.Length) + ext;
            string path = Path.Combine(root, fileName);

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                f.CopyTo(stream);
            }

            list.Add(fileName);
        }

        return list;
    }
    
}
