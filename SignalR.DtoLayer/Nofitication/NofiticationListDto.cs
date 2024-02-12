using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.Nofitication;

public class NofiticationListDto : IDto
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
