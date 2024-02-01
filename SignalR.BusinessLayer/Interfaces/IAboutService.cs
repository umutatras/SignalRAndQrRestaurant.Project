using SignalR.DtoLayer.AbotDtos;
using SignalR.EntityLayer;
using System.Reflection;

namespace SignalR.BusinessLayer.Interfaces
{
    public interface IAboutService : IService<AboutCreateDto, AboutUpdateDto, AboutListDto, About>
    {
    }
}
