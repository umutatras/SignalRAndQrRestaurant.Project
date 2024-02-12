using AutoMapper;
using SignalR.DtoLayer.Nofitication;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class NotificationProfile : Profile
{
    public NotificationProfile()
    {
        CreateMap<Nofitication, NotificationCreateDto>().ReverseMap();
        CreateMap<Nofitication, NofiticationListDto>().ReverseMap();
        CreateMap<Nofitication, NofiticationUpdateDto>().ReverseMap();
    }
}
