namespace SignalR.WebUI.Dtos;

public class BasketListDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int DeskId { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
}
