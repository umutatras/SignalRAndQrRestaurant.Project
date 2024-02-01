using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.AbotDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class AboutManager : ServiceManager<AboutCreateDto, AboutUpdateDto, AboutListDto, About>, IAboutService
{
    public AboutManager(IMapper mapper, IValidator<AboutCreateDto> createValidator, IValidator<AboutUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
