using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.AbotDtos;
using SignalR.DtoLayer.Interfaces;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IResponse<List<AboutListDto>>> GetAboutList()
        {
            var result = await _aboutService.GetAllAsync();
            return result;
        }
        [HttpGet]
        public async Task<IResponse<AboutListDto>> GetById(int id)
        {
            var result = await _aboutService.GetByIdAsync<AboutListDto>(id);
            return result;
        }
        [HttpPost]
        public async Task<IResponse<AboutCreateDto>> Add(AboutCreateDto dto)
        {
            var result = await _aboutService.CreateAsync(dto);
            return result;
        }
        [HttpPut]
        public async Task<IResponse<AboutUpdateDto>> Update(AboutUpdateDto dto)
        {
            var result = await _aboutService.UpdateAsync(dto);
            return result;
        }
        [HttpDelete]
        public async Task<IResponse> Remove(int id)
        {
            var result = await _aboutService.RemoveAsync(id);
            return result;
        }
    }
}
