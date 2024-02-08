using AutoMapper;
using SignalR.DtoLayer.SliderDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class SliderProfile : Profile
{
	public SliderProfile()
	{
		CreateMap<Slider,SliderListDto>().ReverseMap();
		CreateMap<Slider,SliderCreateDto>().ReverseMap();
		CreateMap<Slider,SliderUpdateDto>().ReverseMap();
	}
}
