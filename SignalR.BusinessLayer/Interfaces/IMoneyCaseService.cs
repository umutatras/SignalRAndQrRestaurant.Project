using SignalR.DtoLayer.MoneyCase;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface IMoneyCaseService : IService<MoneyCaseCreateDto, MoneyCaseUpdateDto, MoneyCaseListDto, MoneyCase>
{
    decimal TotalMoneyCaseAmount();
}
