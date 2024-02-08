using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.MoneyCase;

public class MoneyCaseUpdateDto:IUpdateDto
{
    public int Id { get; set; }
    public decimal TotalAmount { get; set; }
}
