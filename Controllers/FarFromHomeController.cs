using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;

public class FarFromHomeController : Controller
{
    public IActionResult Index(FarFromHomeModel farFromHome)
    {
        var name = farFromHome.name;
        var hometown = farFromHome.hometown;
        
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
