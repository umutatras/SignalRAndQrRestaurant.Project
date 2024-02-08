using SignalR.DtoLayer.DeskDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IDeskService : IService<DeskCreateDto, DeskUpdateDto, DeskListDto, Desk>
{
}
