using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AuthController:BaseController
{
    public IActionResult Register()
    {
        return View();
    }
}