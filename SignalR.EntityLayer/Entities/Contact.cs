using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class Contact: BaseEntity
{
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
