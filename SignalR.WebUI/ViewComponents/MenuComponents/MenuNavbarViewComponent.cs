using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.MenuComponents;

public class MenuNavbarViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
