using FluentValidation;
using SignalR.DtoLayer.TestimonialDtos;

namespace SignalR.BusinessLayer.ValidationRules.Testimonial;

public class TestimonialListValidator : AbstractValidator<TestimonialListDto>
{
    public TestimonialListValidator()
    {
    }
}
