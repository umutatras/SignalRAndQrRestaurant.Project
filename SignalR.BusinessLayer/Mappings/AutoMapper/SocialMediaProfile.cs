using AutoMapper;
using SignalR.DtoLayer.SocialMediaDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class SocialMediaProfile : Profile
{
    public SocialMediaProfile()
    {
        CreateMap<SocialMedia, SocialMediaCreateDto>().ReverseMap();
        CreateMap<SocialMedia, SocialMediaListDto>().ReverseMap();
        CreateMap<SocialMedia, SocialMediaUpdateDto>().ReverseMap();

    }
}
