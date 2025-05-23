using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class AuthController:BaseController
{
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(RegisterModel obj)
    {
        Provider.Member.Add(obj);
        return View();
    }
}