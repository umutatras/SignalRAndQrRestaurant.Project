using AutoMapper;
using SignalR.DtoLayer.FeatureDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class FeatureProfile:Profile
{
    public FeatureProfile()
    {
        CreateMap<Feature,FeatureCreateDto>().ReverseMap();
        CreateMap<Feature,FeatureListDto>().ReverseMap();
        CreateMap<Feature,FeatureUpdateDto>().ReverseMap();
    }
}
