using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.DiscountDtos;

public class DiscountUpdateDto : IUpdateDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
}
