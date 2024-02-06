using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.LayoutComponents;

public class LayoutScriptViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
