using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExplorPlanner.Models;

namespace ExplorPlanner.Controllers;

public class ScheduleController : Controller
{
    private readonly ILogger<ScheduleController> _logger;

    public ScheduleController(ILogger<ScheduleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Schedule()
    {
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
