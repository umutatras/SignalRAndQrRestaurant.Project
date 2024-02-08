using FluentValidation;
using SignalR.DtoLayer.SliderDtos;

namespace SignalR.BusinessLayer.ValidationRules.Slider;

public class SliderUpdateValidator:AbstractValidator<SliderUpdateDto>
{
    public SliderUpdateValidator()
    {
        
    }
}
