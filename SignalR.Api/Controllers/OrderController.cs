using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.Order;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IResponse<List<OrderListDto>>> GetOrderList()
    {
        var result = await _orderService.GetAllAsync();
        return result;
    } 
    [HttpGet]
    public decimal TodayTotalPrice()
    {
        var result =  _orderService.TodayTotalPrice();
        return result;
    }
    [HttpGet]
    public int TotalOrderCount()
    {
        var result =  _orderService.TotalOrderCount();
        return result;
    } 
    [HttpGet]
    public decimal EndOrderPrice()
    {
        var result =  _orderService.EndOrderPrice();
        return result;
    }
    [HttpGet]
    public int ActiveOrderCount()
    {
        var result =  _orderService.ActiveOrderCount();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<OrderListDto>> GetById(int id)
    {
        var result = await _orderService.GetByIdAsync<OrderListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<OrderCreateDto>> Add(OrderCreateDto dto)
    {
        var result = await _orderService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<OrderUpdateDto>> Update(OrderUpdateDto dto)
    {
        var result = await _orderService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _orderService.RemoveAsync(id);
        return result;
    }
}
