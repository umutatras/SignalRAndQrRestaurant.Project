using FluentValidation;
using SignalR.DtoLayer.SocialMediaDtos;

namespace SignalR.BusinessLayer.ValidationRules.SocialMedia;

public class SocialMediaCreateValidator : AbstractValidator<SocialMediaCreateDto>
{
    public SocialMediaCreateValidator()
    {
    }
}
