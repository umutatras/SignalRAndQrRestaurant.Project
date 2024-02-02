using FluentValidation;
using SignalR.DtoLayer.AbotDtos;

namespace SignalR.BusinessLayer.ValidationRules.About;

public class AboutUpdateValidator : AbstractValidator<AboutUpdateDto>
{
    public AboutUpdateValidator()
    {

    }

}
