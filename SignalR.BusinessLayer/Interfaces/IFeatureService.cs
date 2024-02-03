using SignalR.DtoLayer.FeatureDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IFeatureService:IService<FeatureCreateDto, FeatureUpdateDto,FeatureListDto,Feature>
{
}
