namespace SignalR.EntityLayer.Entities;

public class Desk : BaseEntity
{
    public string Name { get; set; }
    public bool Status { get; set; }
    public virtual List<Basket> Basket { get; set; }
}
