using FluentValidation;
using SignalR.DtoLayer.DiscountDtos;

namespace SignalR.BusinessLayer.ValidationRules.Discount;

public class DiscountUpdateValidator : AbstractValidator<DiscountUpdateDto>
{
    public DiscountUpdateValidator()
    {
    }
}
