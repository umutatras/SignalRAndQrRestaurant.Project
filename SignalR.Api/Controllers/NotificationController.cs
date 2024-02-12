using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.Nofitication;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    [HttpGet]
    public async Task<IResponse<List<NofiticationListDto>>> GetNotificationList()
    {
        var result = await _notificationService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<NofiticationListDto>> GetById(int id)
    {
        var result = await _notificationService.GetByIdAsync<NofiticationListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<NotificationCreateDto>> Add(NotificationCreateDto dto)
    {
        var result = await _notificationService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<NofiticationUpdateDto>> Update(NofiticationUpdateDto dto)
    {
        var result = await _notificationService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _notificationService.RemoveAsync(id);
        return result;
    }
}
