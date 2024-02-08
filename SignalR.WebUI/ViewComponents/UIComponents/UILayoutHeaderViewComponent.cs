using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.UIComponents;

public class UILayoutHeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
