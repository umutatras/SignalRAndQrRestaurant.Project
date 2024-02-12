using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.Nofitication;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class NotificationManager : ServiceManager<NotificationCreateDto, NofiticationUpdateDto, NofiticationListDto, Nofitication>, INotificationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public NotificationManager(IMapper mapper, IValidator<NotificationCreateDto> createValidator, IValidator<NofiticationUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _mapper=mapper;
    }

    public List<NofiticationListDto> GetAllNotifyByFalse()
    {
        var noti = _unitOfWork.GetRepository<Nofitication>().Query().Where(x => x.Status == false).ToList();
        var result=_mapper.Map<List<NofiticationListDto>>(noti);
        return result;
    }

    public int NotificationCountByStatusFalse()
    {
        var result = _unitOfWork.GetRepository<Nofitication>().Query().Where(x=>x.Status==false).Count();
        return result;  
    }
}
