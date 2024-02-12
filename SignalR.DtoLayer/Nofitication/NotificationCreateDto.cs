using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.Nofitication;

public class NotificationCreateDto : IDto
{
    public string Description { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
