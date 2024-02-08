using FluentValidation;
using SignalR.DtoLayer.SliderDtos;

namespace SignalR.BusinessLayer.ValidationRules.Slider;

public class SliderCreateValidator:AbstractValidator<SliderCreateDto>
{
    public SliderCreateValidator()
    {
        
    }
}
