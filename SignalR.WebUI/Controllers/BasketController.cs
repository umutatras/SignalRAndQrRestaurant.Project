using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;
using System.Text;

namespace SignalR.WebUI.Controllers;

public class BasketController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BasketController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/basket/GetBasketByMenuTableNumber?id=2");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<BasketListProductNameDto>>(jsonData);
            return View(values);
        }
        return View();

    }

    public async Task<IActionResult> DeleteBasket(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync("https://localhost:7250/api/basket/remove?id="+id);
        if (responseMessage.IsSuccessStatusCode)
        {
          
            return RedirectToAction("Index");
        }
        return NoContent();

    }


}