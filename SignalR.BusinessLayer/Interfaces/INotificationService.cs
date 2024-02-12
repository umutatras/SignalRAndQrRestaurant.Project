using SignalR.DtoLayer.Nofitication;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface INotificationService : IService<NotificationCreateDto, NofiticationUpdateDto, NofiticationListDto, Nofitication>
{
}
