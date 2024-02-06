using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.LayoutComponents;

public class LayoutSidebarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
