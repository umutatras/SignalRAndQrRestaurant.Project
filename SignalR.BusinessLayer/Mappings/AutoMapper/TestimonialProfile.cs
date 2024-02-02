using AutoMapper;
using SignalR.DtoLayer.TestimonialDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class TestimonialProfile : Profile
{
    public TestimonialProfile()
    {
        CreateMap<Testimonial, TestimonialCreateDto>().ReverseMap();
        CreateMap<Testimonial, TestimonialListDto>().ReverseMap();
        CreateMap<Testimonial, TestimonialUpdateDto>().ReverseMap();

    }
}
