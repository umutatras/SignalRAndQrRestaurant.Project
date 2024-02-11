using AutoMapper;
using SignalR.DtoLayer.BasketDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class BasketProfile : Profile
{
    public BasketProfile()
    {
        CreateMap<Basket, BasketListDto>().ReverseMap();
        CreateMap<Basket, BasketCreateDto>().ReverseMap();
        CreateMap<Basket, BasketUpdateDto>().ReverseMap();
        CreateMap<Basket, BasketListProductNameDto>().ForMember(e=>e.ProductName,opt=>opt.MapFrom(opt=>opt.Product.Name)).ReverseMap();
    }
}
