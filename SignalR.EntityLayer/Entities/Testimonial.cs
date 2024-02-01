using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class Testimonial: BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}
