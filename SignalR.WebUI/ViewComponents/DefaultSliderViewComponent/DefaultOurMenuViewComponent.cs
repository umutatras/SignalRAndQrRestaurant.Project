﻿using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultOurMenuViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
