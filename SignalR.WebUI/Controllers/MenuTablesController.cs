using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos;
using System.Text;

namespace SignalR.WebUI.Controllers;

public class MenuTablesController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MenuTablesController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/desk/GetDeskList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<DeskListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();
    }

    public IActionResult CreateDesk()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateDesk(DeskCreateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7250/api/desk/add", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }
    public async Task<IActionResult> DeleteDesk(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7250/api/desk/remove?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    public async Task<IActionResult> UpdateDesk(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7250/api/desk/getbyid?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<DeskUpdateDto>>(jsonData);
            return View(values.Data);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateDesk(DeskUpdateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7250/api/desk/update", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }
    public async Task<IActionResult> TableListByStatus()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7250/api/desk/GetDeskList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResponseDto<List<DeskListDto>>>(jsonData);
            return View(values.Data);
        }
        return View();
    }



}
