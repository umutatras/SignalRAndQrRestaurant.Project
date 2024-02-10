using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.BasketDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class BasketManager : ServiceManager<BasketCreateDto, BasketUpdateDto, BasketListDto, Basket>, IBasketService
{
    private readonly IUnitOfWork _unitOfWork;
    public BasketManager(IMapper mapper, IValidator<BasketCreateDto> createValidator, IValidator<BasketUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork=unitOfWork;
    }
}
