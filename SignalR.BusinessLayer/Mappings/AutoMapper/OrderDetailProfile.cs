using AutoMapper;
using SignalR.DtoLayer.OrderDetail;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class OrderDetailProfile:Profile
{
    public OrderDetailProfile()
    {
        CreateMap<OrderDetail, OrderDetailCreateDto>().ReverseMap();
        CreateMap<OrderDetail, OrderDetailListDto>().ReverseMap();
        CreateMap<OrderDetail, OrderDetailUpdateDto>().ReverseMap();
    }
}
