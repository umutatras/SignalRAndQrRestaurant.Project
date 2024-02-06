using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.LayoutComponents;

public class LayoutFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View(); 
    }
}
