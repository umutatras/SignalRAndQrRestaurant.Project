using SignalR.DtoLayer.OrderDetail;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IOrderDetailService : IService<OrderDetailCreateDto, OrderDetailUpdateDto, OrderDetailListDto, OrderDetail>
{
}
