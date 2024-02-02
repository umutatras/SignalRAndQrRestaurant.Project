using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.SocialMediaDtos;

public class SocialMediaCreateDto : IDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
