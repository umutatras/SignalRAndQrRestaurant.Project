using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.SocialMediaDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
    private readonly ISocialMediaService _socialMediaService;

    public SocialMediaController(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }
    [HttpGet]
    public async Task<IResponse<List<SocialMediaListDto>>> GetAboutList()
    {
        var result = await _socialMediaService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<SocialMediaListDto>> GetById(int id)
    {
        var result = await _socialMediaService.GetByIdAsync<SocialMediaListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<SocialMediaCreateDto>> Add(SocialMediaCreateDto dto)
    {
        var result = await _socialMediaService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<SocialMediaUpdateDto>> Update(SocialMediaUpdateDto dto)
    {
        var result = await _socialMediaService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _socialMediaService.RemoveAsync(id);
        return result;
    }
}
