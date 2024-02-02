using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.FeatureDtos;

public class FeatureCreateDto : IDto
{
    public string Title { get; set; }
    public string Description { get; set; }
}
