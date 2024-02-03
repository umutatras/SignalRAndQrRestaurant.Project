using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.DiscountDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class DiscountManager : ServiceManager<DiscountCreateDto, DiscountUpdateDto, DiscountListDto, Discount>, IDiscountService
{
    public DiscountManager(IMapper mapper, IValidator<DiscountCreateDto> createValidator, IValidator<DiscountUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
