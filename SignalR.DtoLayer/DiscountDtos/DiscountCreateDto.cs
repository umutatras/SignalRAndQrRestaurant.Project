using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.DiscountDtos;

public class DiscountCreateDto : IDto
{
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
}
