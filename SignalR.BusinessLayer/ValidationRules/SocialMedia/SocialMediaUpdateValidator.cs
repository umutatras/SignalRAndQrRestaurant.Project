using FluentValidation;
using SignalR.DtoLayer.SocialMediaDtos;

namespace SignalR.BusinessLayer.ValidationRules.SocialMedia;

public class SocialMediaUpdateValidator : AbstractValidator<SocialMediaUpdateDto>
{
    public SocialMediaUpdateValidator()
    {
    }
}
