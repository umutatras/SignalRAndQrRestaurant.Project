using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.MoneyCase;

public class MoneyCaseCreateDto : IDto
{
    public decimal TotalAmount { get; set; }
}
