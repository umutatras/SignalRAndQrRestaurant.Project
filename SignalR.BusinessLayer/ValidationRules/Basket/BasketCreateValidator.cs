using FluentValidation;
using SignalR.DtoLayer.BasketDtos;

namespace SignalR.BusinessLayer.ValidationRules.Basket;

public class BasketCreateValidator : AbstractValidator<BasketCreateDto>
{
    public BasketCreateValidator()
    {

    }
}
