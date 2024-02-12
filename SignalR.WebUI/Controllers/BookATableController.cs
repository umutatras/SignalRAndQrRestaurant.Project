using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;
using System.Text;

namespace SignalR.WebUI.Controllers;

public class BookATableController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BookATableController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(BookingCreateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7250/api/booking/add", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index","Default");
        }
        return View(dto);
    }
}
