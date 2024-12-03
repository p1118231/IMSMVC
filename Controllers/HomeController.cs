using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


using IMSMVC.Models;

namespace IMSMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         if (!User.Identity.IsAuthenticated)
    {
        return RedirectToAction("SignIn");
    }

        return View();
    }

            public IActionResult SignIn()
        {
            return View();
        }

    public IActionResult Login(string returnUrl = "/")
    {
        var authenticationProperties = new AuthenticationProperties { RedirectUri = returnUrl };
        return Challenge(authenticationProperties, "Auth0");
    }

    public IActionResult Logout()
    {
        return SignOut(new AuthenticationProperties
        {
            RedirectUri = Url.Action("SignIn", "Home")
        }, CookieAuthenticationDefaults.AuthenticationScheme, "Auth0");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
