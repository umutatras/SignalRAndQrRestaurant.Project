using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.SliderDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class SliderController : ControllerBase
{
    private readonly ISliderService _sliderService;

    public SliderController(ISliderService sliderService)
    {
        _sliderService = sliderService;
    }
    [HttpGet]
    public async Task<IResponse<List<SliderListDto>>> GetSliderList()
    {
        var result = await _sliderService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<SliderListDto>> GetById(int id)
    {
        var result = await _sliderService.GetByIdAsync<SliderListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<SliderCreateDto>> Add(SliderCreateDto dto)
    {
        var result = await _sliderService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<SliderUpdateDto>> Update(SliderUpdateDto dto)
    {
        var result = await _sliderService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _sliderService.RemoveAsync(id);
        return result;
    }
}
