using FluentValidation;
using SignalR.DtoLayer.TestimonialDtos;

namespace SignalR.BusinessLayer.ValidationRules.Testimonial;

public class TestimonialUpdateValidator : AbstractValidator<TestimonialUpdateDto>
{
    public TestimonialUpdateValidator()
    {
    }
}
