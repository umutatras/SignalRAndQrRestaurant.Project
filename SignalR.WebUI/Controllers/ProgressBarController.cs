using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers;

public class ProgressBarController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
