using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AuthController : BaseController
    {
        [HttpPost("register")]
        public int Register(RegisterModel obj)
        {
            return Provider.Member.Add(obj);
        }
    }
}
