using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;

namespace SignalR.WebUI.ViewComponents.UIComponents;

public class FooterHelperSocialMediaViewComponent:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public FooterHelperSocialMediaViewComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/socialmedia/GetSocialMediaList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<SocialMediaListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();

    }
}
