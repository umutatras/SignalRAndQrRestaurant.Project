using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.MoneyCase;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class MoneyCaseManager : ServiceManager<MoneyCaseCreateDto, MoneyCaseUpdateDto, MoneyCaseListDto, MoneyCase>, IMoneyCaseService
{
    private readonly IUnitOfWork _unitOfWork;
    public MoneyCaseManager(IMapper mapper, IValidator<MoneyCaseCreateDto> createValidator, IValidator<MoneyCaseUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public decimal TotalMoneyCaseAmount()
    {
        var result=_unitOfWork.GetRepository<MoneyCase>()
            .Query()
            .Select(s=>s.TotalAmount).FirstOrDefault();
        return result;  
    }
}
