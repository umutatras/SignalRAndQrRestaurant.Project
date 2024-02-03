using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.TestimonialDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TestimonialController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialController(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }
    [HttpGet]
    public async Task<IResponse<List<TestimonialListDto>>> GetAboutList()
    {
        var result = await _testimonialService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<TestimonialListDto>> GetById(int id)
    {
        var result = await _testimonialService.GetByIdAsync<TestimonialListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<TestimonialCreateDto>> Add(TestimonialCreateDto dto)
    {
        var result = await _testimonialService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<TestimonialUpdateDto>> Update(TestimonialUpdateDto dto)
    {
        var result = await _testimonialService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _testimonialService.RemoveAsync(id);
        return result;
    }
}
