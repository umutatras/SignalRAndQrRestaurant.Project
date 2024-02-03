using FluentValidation;
using SignalR.DtoLayer.DiscountDtos;

namespace SignalR.BusinessLayer.ValidationRules.Discount;

public class DiscountCreateValidator : AbstractValidator<DiscountCreateDto>
{
    public DiscountCreateValidator()
    {
    }
}
