using AutoMapper;
using SignalR.DtoLayer.AbotDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class AboutProfile : Profile
{
    public AboutProfile()
    {
        CreateMap<About, AboutCreateDto>().ReverseMap();
    }
}
