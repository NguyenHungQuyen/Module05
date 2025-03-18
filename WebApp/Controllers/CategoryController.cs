using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class CategoryController : BaseController
{
    public async Task<IActionResult> Index()
    {
        return View(await Provider.Category.GetCategoriesAsync());
    }

    public IActionResult Add() => View();

[HttpPost]
public async Task<IActionResult> Add(Category obj){
    if(ModelState.IsValid){
        int ret = await Provider.Category.AddAsync(obj);
        if(ret > 0){
            return Redirect("/category");
        }
        string[] arr = {"Error", "Insert Failed"};
        ModelState.AddModelError("Error", arr[ret + 1]);
    }
    return View(obj);
}

}


