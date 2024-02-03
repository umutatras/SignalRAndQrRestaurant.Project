using FluentValidation;
using SignalR.DtoLayer.FeatureDtos;

namespace SignalR.BusinessLayer.ValidationRules.Feature;

public class FeatureListValidator : AbstractValidator<FeatureListDto>
{
    public FeatureListValidator()
    {
    }
}
