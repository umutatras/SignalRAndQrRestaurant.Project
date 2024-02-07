using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.OrderDetail;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class OrderDetailManager : ServiceManager<OrderDetailCreateDto, OrderDetailUpdateDto, OrderDetailListDto, OrderDetail>,IOrderDetailService
{
    public OrderDetailManager(IMapper mapper, IValidator<OrderDetailCreateDto> createValidator, IValidator<OrderDetailUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
