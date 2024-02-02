using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.TestimonialDtos;

public class TestimonialCreateDto : IDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}
