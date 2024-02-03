using SignalR.DtoLayer.TestimonialDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface ITestimonialService : IService<TestimonialCreateDto, TestimonialUpdateDto, TestimonialListDto, Testimonial>
{
}
