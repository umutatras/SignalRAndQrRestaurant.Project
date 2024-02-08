using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.UIComponents;

public class UILayoutHeadViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
