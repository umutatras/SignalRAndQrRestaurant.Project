using FluentValidation;
using SignalR.DtoLayer.FeatureDtos;

namespace SignalR.BusinessLayer.ValidationRules.Feature;

public class FeatureCreateValidator : AbstractValidator<FeatureCreateDto>
{
    public FeatureCreateValidator()
    {
    }
}
