using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.OrderDetail;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class OrderDetailController : ControllerBase
{
    private readonly IOrderDetailService _orderDetailService;

    public OrderDetailController(IOrderDetailService orderDetailService)
    {
        _orderDetailService = orderDetailService;
    }
    [HttpGet]
    public async Task<IResponse<List<OrderDetailListDto>>> GetOrderDetailList()
    {
        var result = await _orderDetailService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<OrderDetailListDto>> GetById(int id)
    {
        var result = await _orderDetailService.GetByIdAsync<OrderDetailListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<OrderDetailCreateDto>> Add(OrderDetailCreateDto dto)
    {
        var result = await _orderDetailService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<OrderDetailUpdateDto>> Update(OrderDetailUpdateDto dto)
    {
        var result = await _orderDetailService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _orderDetailService.RemoveAsync(id);
        return result;
    }
}
