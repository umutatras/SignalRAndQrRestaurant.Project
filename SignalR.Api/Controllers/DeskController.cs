using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.DeskDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class DeskController : ControllerBase
{
    private readonly IDeskService _deskService;

    public DeskController(IDeskService deskService)
    {
        _deskService = deskService;
    }
    [HttpGet]
    public async Task<IResponse<List<DeskListDto>>> GetDeskList()
    {
        var result = await _deskService.GetAllAsync();
        return result;
    } 
    [HttpGet]
    public int MenuTableCount()
    {
        var result =  _deskService.MenuTableCount();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<DeskListDto>> GetById(int id)
    {
        var result = await _deskService.GetByIdAsync<DeskListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<DeskCreateDto>> Add(DeskCreateDto dto)
    {
        var result = await _deskService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<DeskUpdateDto>> Update(DeskUpdateDto dto)
    {
        var result = await _deskService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _deskService.RemoveAsync(id);
        return result;
    }
}
