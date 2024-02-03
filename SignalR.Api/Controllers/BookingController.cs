using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.BookingDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }
    [HttpGet]
    public async Task<IResponse<List<BookingListDto>>> GetBookingList()
    {
        var result = await _bookingService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<BookingListDto>> GetById(int id)
    {
        var result = await _bookingService.GetByIdAsync<BookingListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<BookingCreateDto>> Add(BookingCreateDto dto)
    {
        var result = await _bookingService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<BookingUpdateDto>> Update(BookingUpdateDto dto)
    {
        var result = await _bookingService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _bookingService.RemoveAsync(id);
        return result;
    }
}
