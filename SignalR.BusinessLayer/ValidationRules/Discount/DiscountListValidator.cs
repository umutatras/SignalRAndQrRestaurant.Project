using FluentValidation;
using SignalR.DtoLayer.DiscountDtos;

namespace SignalR.BusinessLayer.ValidationRules.Discount;

public class DiscountListValidator : AbstractValidator<DiscountListDto>
{
    public DiscountListValidator()
    {
    }
}
