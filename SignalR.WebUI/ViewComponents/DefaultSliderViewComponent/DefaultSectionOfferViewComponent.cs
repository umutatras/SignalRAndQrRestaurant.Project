using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultSectionOfferViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
