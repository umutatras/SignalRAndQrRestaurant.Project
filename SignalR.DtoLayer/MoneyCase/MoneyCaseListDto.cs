using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.MoneyCase;

public class MoneyCaseListDto : IDto
{
    public int Id { get; set; }
    public decimal TotalAmount { get; set; }
}
