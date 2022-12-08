using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IsTakipSistemi.API.Controllers;

[ApiController]
[Route("api/security")]
[AllowAnonymous]
public class SecurityController : Controller
{
    [HttpPost]
    [Route("login")]
    public IActionResult LoginPost()
    {
        return View();
    }
}
