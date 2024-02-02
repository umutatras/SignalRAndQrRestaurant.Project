using FluentValidation;
using SignalR.DtoLayer.AbotDtos;

namespace SignalR.BusinessLayer.ValidationRules.About;

public class AboutCreateValidator : AbstractValidator<AboutCreateDto>
{
    public AboutCreateValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
    }
}
