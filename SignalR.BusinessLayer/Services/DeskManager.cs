using AutoMapper;
using FluentValidation;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.DeskDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class DeskManager : ServiceManager<DeskCreateDto, DeskUpdateDto, DeskListDto, Desk>
{
    private readonly IUnitOfWork _unitOfWork;
    public DeskManager(IMapper mapper, IValidator<DeskCreateDto> createValidator, IValidator<DeskUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
