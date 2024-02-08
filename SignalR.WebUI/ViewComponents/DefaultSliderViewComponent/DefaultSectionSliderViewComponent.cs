using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultSectionSliderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
