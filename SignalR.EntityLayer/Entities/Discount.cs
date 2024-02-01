using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;
public class Discount: BaseEntity
{
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
}
