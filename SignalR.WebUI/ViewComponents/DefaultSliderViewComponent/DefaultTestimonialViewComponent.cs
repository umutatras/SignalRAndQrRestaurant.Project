using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultTestimonialViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View(); 
    }
}
