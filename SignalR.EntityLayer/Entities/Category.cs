using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class Category: BaseEntity
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
