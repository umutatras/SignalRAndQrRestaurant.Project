using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class About : BaseEntity
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
