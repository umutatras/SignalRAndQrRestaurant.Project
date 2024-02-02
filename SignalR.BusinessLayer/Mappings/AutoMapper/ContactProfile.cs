using AutoMapper;
using SignalR.DtoLayer.ContactDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<Contact, ContactCreateDto>().ReverseMap();
        CreateMap<Contact, ContactListDto>().ReverseMap();
        CreateMap<Contact, ContactUpdateDto>().ReverseMap();
    }
}
