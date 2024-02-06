using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.LayoutComponents;

public class LayoutNavbarViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
