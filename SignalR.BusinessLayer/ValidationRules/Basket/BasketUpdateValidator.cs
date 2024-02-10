using FluentValidation;
using SignalR.DtoLayer.BasketDtos;

namespace SignalR.BusinessLayer.ValidationRules.Basket;

public class BasketUpdateValidator : AbstractValidator<BasketUpdateDto>
{
    public BasketUpdateValidator()
    {

    }
}
