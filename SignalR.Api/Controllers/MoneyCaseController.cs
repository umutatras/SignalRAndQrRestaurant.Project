using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.MoneyCase;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MoneyCaseController : Controller
{
    private readonly IMoneyCaseService _moneyCaseService;

    public MoneyCaseController(IMoneyCaseService moneyCaseService)
    {
        _moneyCaseService = moneyCaseService;
    }

    [HttpGet]
    public async Task<IResponse<List<MoneyCaseListDto>>> GetMoneyCaseList()
    {
        var result = await _moneyCaseService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public decimal TotalMoneyCaseAmount()
    {
        var result =  _moneyCaseService.TotalMoneyCaseAmount();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<MoneyCaseListDto>> GetById(int id)
    {
        var result = await _moneyCaseService.GetByIdAsync<MoneyCaseListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<MoneyCaseCreateDto>> Add(MoneyCaseCreateDto dto)
    {
        var result = await _moneyCaseService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<MoneyCaseUpdateDto>> Update(MoneyCaseUpdateDto dto)
    {
        var result = await _moneyCaseService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _moneyCaseService.RemoveAsync(id);
        return result;
    }
}
