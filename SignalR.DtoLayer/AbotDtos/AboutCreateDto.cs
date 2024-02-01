using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.AbotDtos;

public class AboutCreateDto : IDto
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
