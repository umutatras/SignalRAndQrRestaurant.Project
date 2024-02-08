using SignalR.DtoLayer.SliderDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Interfaces;

public interface ISliderService:IService<SliderCreateDto,SliderUpdateDto,SliderListDto,Slider>
{
}
