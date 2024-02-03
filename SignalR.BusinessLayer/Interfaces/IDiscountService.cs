using SignalR.DtoLayer.DiscountDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IDiscountService : IService<DiscountCreateDto, DiscountUpdateDto, DiscountListDto, Discount>
{
}
