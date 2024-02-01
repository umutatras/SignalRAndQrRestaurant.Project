using SignalR.DtoLayer.Interfaces;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
{

}
