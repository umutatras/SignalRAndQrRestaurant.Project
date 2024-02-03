using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.ContactDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }
    [HttpGet]
    public async Task<IResponse<List<ContactListDto>>> GetContactList()
    {
        var result = await _contactService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<ContactListDto>> GetById(int id)
    {
        var result = await _contactService.GetByIdAsync<ContactListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<ContactCreateDto>> Add(ContactCreateDto dto)
    {
        var result = await _contactService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<ContactUpdateDto>> Update(ContactUpdateDto dto)
    {
        var result = await _contactService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _contactService.RemoveAsync(id);
        return result;
    }
}
