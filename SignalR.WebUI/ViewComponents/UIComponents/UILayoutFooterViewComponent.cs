using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.UIComponents;

public class UILayoutFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
