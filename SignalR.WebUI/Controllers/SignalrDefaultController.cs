using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers;

public class SignalrDefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Index2()
    {
        return View();
    }
}
