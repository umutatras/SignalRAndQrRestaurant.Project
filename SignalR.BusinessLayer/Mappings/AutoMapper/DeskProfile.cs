using AutoMapper;
using SignalR.DtoLayer.DeskDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class DeskProfile : Profile
{
    public DeskProfile()
    {
        CreateMap<Desk, DeskListDto>().ReverseMap();
        CreateMap<Desk, DeskCreateDto>().ReverseMap();
        CreateMap<Desk, DeskUpdateDto>().ReverseMap();

    }
}
