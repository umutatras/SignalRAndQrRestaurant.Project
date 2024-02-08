using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultBookSectionViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
