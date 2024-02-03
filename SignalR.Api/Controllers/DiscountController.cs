using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.DiscountDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class DiscountController : ControllerBase
{
    private readonly IDiscountService _discountService;

    public DiscountController(IDiscountService discountService)
    {
        _discountService = discountService;
    }
    [HttpGet]
    public async Task<IResponse<List<DiscountListDto>>> GetDiscountList()
    {
        var result = await _discountService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<DiscountListDto>> GetById(int id)
    {
        var result = await _discountService.GetByIdAsync<DiscountListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<DiscountCreateDto>> Add(DiscountCreateDto dto)
    {
        var result = await _discountService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<DiscountUpdateDto>> Update(DiscountUpdateDto dto)
    {
        var result = await _discountService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _discountService.RemoveAsync(id);
        return result;
    }

}
