using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

public abstract class BaseController : ControllerBase
{
    SiteProvider? provider;

    protected SiteProvider Provider => provider 
        ??= new SiteProvider(HttpContext.RequestServices.GetRequiredService<IConfiguration>());
}
