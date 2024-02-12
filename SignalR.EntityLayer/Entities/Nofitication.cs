namespace SignalR.EntityLayer.Entities;

public class Nofitication : BaseEntity
{
    public string Description { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
