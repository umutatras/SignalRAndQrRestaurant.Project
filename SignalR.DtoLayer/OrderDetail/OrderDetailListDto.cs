using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.OrderDetail;

public class OrderDetailListDto:IDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public int Count { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
