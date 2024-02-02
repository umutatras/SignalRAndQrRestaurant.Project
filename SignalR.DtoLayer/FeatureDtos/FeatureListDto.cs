using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.FeatureDtos;

public class FeatureListDto : IDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
