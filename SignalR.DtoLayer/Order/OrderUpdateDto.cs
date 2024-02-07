using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.Order;

public class OrderUpdateDto:IUpdateDto
{
    public int Id { get; set; }
    public string TableNumber { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }
}
