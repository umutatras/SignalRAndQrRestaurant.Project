using FluentValidation;
using SignalR.DtoLayer.BasketDtos;

namespace SignalR.BusinessLayer.ValidationRules.Basket;

public class BasketListValidator : AbstractValidator<BasketListDto>
{
    public BasketListValidator()
    {

    }
}
