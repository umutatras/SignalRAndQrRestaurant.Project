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
    private readonly IMapper _mapper;
    public BasketManager(IMapper mapper, IValidator<BasketCreateDto> createValidator, IValidator<BasketUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _mapper = mapper;
    }

    public List<BasketListDto> GetBasketByMenuTableNumber(int id)
    {
       var baskets= _unitOfWork.GetRepository<Basket>().Query().Where(x=>x.DeskId==id).ToList();
       var result=_mapper.Map<List<BasketListDto>>(baskets);
        return result;
    }
}
