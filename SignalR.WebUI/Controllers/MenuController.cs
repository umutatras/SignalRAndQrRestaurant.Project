using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;
using System.Text;

namespace SignalR.WebUI.Controllers;

public class MenuController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MenuController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/product/GetProductList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<ProductListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();

    }

    [HttpPost]
    public async Task<IActionResult> AddBasket(int id)
    {
        var createBasketDto = new BasketCreateDto();
        createBasketDto.ProductId = id;
        createBasketDto.DeskId = 2;
        var client = _httpClientFactory.CreateClient();    
        var responseMessage2 = await client.GetAsync("https://localhost:7250/api/product/getbyid?id="+id);
        if (responseMessage2.IsSuccessStatusCode)
        {
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<ResponseDto<ProductListDto>>(jsonData2);
            createBasketDto.Price = values2.Data.Price;
            createBasketDto.Count = 1;
         
            createBasketDto.TotalPrice = values2.Data.Price * createBasketDto.Count;
        }
        var jsonData = JsonConvert.SerializeObject(createBasketDto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7250/api/basket/add", content);

        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return Json(createBasketDto);
    }
}
