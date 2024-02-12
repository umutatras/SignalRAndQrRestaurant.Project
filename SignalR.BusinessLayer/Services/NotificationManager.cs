using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.Nofitication;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class NotificationManager : ServiceManager<NotificationCreateDto, NofiticationUpdateDto, NofiticationListDto, Nofitication>, INotificationService
{
    public NotificationManager(IMapper mapper, IValidator<NotificationCreateDto> createValidator, IValidator<NofiticationUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
