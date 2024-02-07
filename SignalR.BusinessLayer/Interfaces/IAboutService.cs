using SignalR.DtoLayer.AbotDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IAboutService : IService<AboutCreateDto, AboutUpdateDto, AboutListDto, About>
{
}
