using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers;

public class StatisticController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
