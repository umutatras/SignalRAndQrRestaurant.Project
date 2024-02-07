using AutoMapper;
using SignalR.DtoLayer.Order;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderCreateDto>().ReverseMap();
        CreateMap<Order, OrderListDto>().ReverseMap();
        CreateMap<Order, OrderUpdateDto>().ReverseMap();
    }
}
