using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers;

public class UILayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
