using SignalR.DtoLayer.BasketDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IBasketService : IService<BasketCreateDto, BasketUpdateDto, BasketListDto, Basket>
{
    List<BasketListProductNameDto> GetBasketByMenuTableNumber(int id);
}
