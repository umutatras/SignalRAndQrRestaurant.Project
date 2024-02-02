using FluentValidation;
using SignalR.DtoLayer.AbotDtos;

namespace SignalR.BusinessLayer.ValidationRules.About;

public class AboutListValidator:AbstractValidator<AboutListDto>
{
    public AboutListValidator()
    {
        
    }
}
