using SignalR.DtoLayer.Order;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IOrderService : IService<OrderCreateDto, OrderUpdateDto, OrderListDto, Order>
{
    int TotalOrderCount();
    int ActiveOrderCount();
    decimal EndOrderPrice();
}
