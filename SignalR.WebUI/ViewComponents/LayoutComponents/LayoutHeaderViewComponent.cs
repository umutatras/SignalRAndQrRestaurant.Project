using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.LayoutComponents;

public class LayoutHeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
