using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;

public class NoWayHomeController : Controller
{
    public IActionResult Index(NoWayHomeModel noWayHome)
    {
        var name = noWayHome.name;
        var hometown = noWayHome.hometown;
        
        ViewData["name"] = name;
        ViewData["hometown"] = hometown;

        return View();
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
