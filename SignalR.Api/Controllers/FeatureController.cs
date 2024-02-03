using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.FeatureDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class FeatureController : ControllerBase
{
    private readonly IFeatureService _featureService;

    public FeatureController(IFeatureService featureService)
    {
        _featureService = featureService;
    }
    [HttpGet]
    public async Task<IResponse<List<FeatureListDto>>> GetFeatureList()
    {
        var result = await _featureService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<FeatureListDto>> GetById(int id)
    {
        var result = await _featureService.GetByIdAsync<FeatureListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<FeatureCreateDto>> Add(FeatureCreateDto dto)
    {
        var result = await _featureService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<FeatureUpdateDto>> Update(FeatureUpdateDto dto)
    {
        var result = await _featureService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _featureService.RemoveAsync(id);
        return result;
    }
}
