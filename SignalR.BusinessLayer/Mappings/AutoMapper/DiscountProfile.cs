using AutoMapper;
using SignalR.DtoLayer.DiscountDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class DiscountProfile : Profile
{
    public DiscountProfile()
    {
        CreateMap<Discount, DiscountCreateDto>().ReverseMap();
        CreateMap<Discount, DiscountUpdateDto>().ReverseMap();
        CreateMap<Discount, DiscountListDto>().ReverseMap();
    }
}
