using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.AbotDtos;

public class AboutUpdateDto : IUpdateDto
{
    public int Id { get ; set ; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
