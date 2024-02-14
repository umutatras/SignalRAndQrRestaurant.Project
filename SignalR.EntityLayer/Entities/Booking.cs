using SignalR.EntityLayer.Entities;

namespace SignalR.EntityLayer;

public class Booking: BaseEntity
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string Description { get; set; }
    public int PersonCount { get; set; }
    public DateTime CreateDate { get; set; }
}
