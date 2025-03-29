using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        [HttpPost("register")]
        public int Register(RegisterModel obj)
        {
            return Provider.Member.Add(obj);
        }
        [HttpPost("login")]
        public string Login(LoginModel obj)
        {
            string token;
            token="";
            return token;
        }
    }

}
