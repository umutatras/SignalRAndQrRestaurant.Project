using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.Order;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class OrderManager : ServiceManager<OrderCreateDto, OrderUpdateDto, OrderListDto, Order>, IOrderService
{
    public OrderManager(IMapper mapper, IValidator<OrderCreateDto> createValidator, IValidator<OrderUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
