using FluentValidation;
using SignalR.DtoLayer.SocialMediaDtos;

namespace SignalR.BusinessLayer.ValidationRules.SocialMedia;

public class SocialMediaListValidator : AbstractValidator<SocialMediaListDto>
{
    public SocialMediaListValidator()
    {
    }
}
