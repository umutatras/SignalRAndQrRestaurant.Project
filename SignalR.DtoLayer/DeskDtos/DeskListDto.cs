using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.DeskDtos;

public class DeskListDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
