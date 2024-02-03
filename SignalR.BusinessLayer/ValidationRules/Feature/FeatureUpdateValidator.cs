using FluentValidation;
using SignalR.DtoLayer.FeatureDtos;

namespace SignalR.BusinessLayer.ValidationRules.Feature;

public class FeatureUpdateValidator : AbstractValidator<FeatureUpdateDto>
{
    public FeatureUpdateValidator()
    {
    }
}
