using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.BasketDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BasketController : ControllerBase
{
    private readonly IBasketService _basketService;

    public BasketController(IBasketService basketService)
    {
        _basketService = basketService;
    }
    [HttpGet]
    public async Task<IResponse<List<BasketListDto>>> GetBasketList()
    {
        var result = await _basketService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<BasketListDto>> GetById(int id)
    {
        var result = await _basketService.GetByIdAsync<BasketListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<BasketCreateDto>> Add(BasketCreateDto dto)
    {
        var result = await _basketService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<BasketUpdateDto>> Update(BasketUpdateDto dto)
    {
        var result = await _basketService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _basketService.RemoveAsync(id);
        return result;
    }
}
