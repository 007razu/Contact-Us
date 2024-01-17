using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Contact_Us.Models;

namespace Contact_Us.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
  public IActionResult ContactUS(ContactViewModel model)
    {
        return View(model);
    }
}

