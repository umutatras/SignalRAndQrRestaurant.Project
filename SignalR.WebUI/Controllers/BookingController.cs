using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;
using System.Text;

namespace SignalR.WebUI.Controllers;

public class BookingController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BookingController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/booking/GetBookingList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<BookingListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();
    }

    public IActionResult CreateBooking()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateBooking(BookingCreateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7250/api/booking/add", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7250/api/booking/remove?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    public async Task<IActionResult> UpdateBooking(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7250/api/booking/getbyid?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<BookingUpdateDto>>(jsonData);
            return View(values.Data);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateBooking(BookingUpdateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7250/api/booking/update", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }
}
