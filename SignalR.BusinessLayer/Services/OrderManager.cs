using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.Order;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class OrderManager : ServiceManager<OrderCreateDto, OrderUpdateDto, OrderListDto, Order>, IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    public OrderManager(IMapper mapper, IValidator<OrderCreateDto> createValidator, IValidator<OrderUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public int TotalOrderCount()
    {
        var result = _unitOfWork.GetRepository<Order>
             ().Query().Count();
        return result;
    } public int ActiveOrderCount()
    {
        var result = _unitOfWork.GetRepository<Order>
             ().Query()
             .Where(f=>f.Description=="Müşteri Masada").Count();
        return result;
    }

    public decimal EndOrderPrice()
    {
        var result = _unitOfWork.GetRepository<Order>
            ().Query()
            .OrderByDescending(f=>f.Id)
            .FirstOrDefault().TotalPrice;
        return result;
    }

    public decimal TodayTotalPrice()
    {
        var result = _unitOfWork.GetRepository<Order>()
            .Query()
            .Where(x => x.Date.ToShortDateString() == DateTime.Now.ToShortDateString()).Sum(x => x.TotalPrice);
        return result;
    }
}
