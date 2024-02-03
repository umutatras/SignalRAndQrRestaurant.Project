using SignalR.DtoLayer.SocialMediaDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface ISocialMediaService : IService<SocialMediaCreateDto, SocialMediaUpdateDto, SocialMediaListDto, SocialMedia>
{
}
