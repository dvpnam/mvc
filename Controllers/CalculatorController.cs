using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;

public class CalculatorController : Controller
{
    public IActionResult Index(CalculatorModel calculator)
    {
        var num1 = calculator.num1;
        var num2 = calculator.num2;

        ViewData["num1"] = num1;
        ViewData["num2"] = num2;

        var sum = num1 + num2;

        ViewData["sum"] = sum;

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
