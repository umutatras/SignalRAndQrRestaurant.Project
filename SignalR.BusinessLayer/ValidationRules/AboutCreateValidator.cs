using FluentValidation;
using SignalR.DtoLayer.AbotDtos;

namespace SignalR.BusinessLayer.ValidationRules;

public class AboutCreateValidator : AbstractValidator<AboutCreateDto>
{
    public AboutCreateValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
    }
}
