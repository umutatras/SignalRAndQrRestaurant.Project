using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;

namespace SignalR.WebUI.ViewComponents.DefaultSliderViewComponent;

public class DefaultAboutSectionViewComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public DefaultAboutSectionViewComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/about/GetAboutList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<AboutListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();

    }
}
