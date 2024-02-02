using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.FeatureDtos;

public class FeatureUpdateDto : IUpdateDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
