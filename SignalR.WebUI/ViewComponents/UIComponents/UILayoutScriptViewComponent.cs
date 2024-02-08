using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.UIComponents;

public class UILayoutScriptViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
