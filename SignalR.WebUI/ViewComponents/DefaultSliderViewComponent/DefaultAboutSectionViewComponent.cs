using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultAboutSectionViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
