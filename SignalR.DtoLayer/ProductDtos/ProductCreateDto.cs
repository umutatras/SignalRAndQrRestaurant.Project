using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.ProductDtos;

public class ProductCreateDto : IDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
    public int CategoryId { get; set; }
}
