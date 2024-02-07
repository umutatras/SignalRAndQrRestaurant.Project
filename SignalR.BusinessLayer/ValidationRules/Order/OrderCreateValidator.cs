using FluentValidation;
using SignalR.DtoLayer.Order;

namespace SignalR.BusinessLayer.ValidationRules.Order;

public class OrderCreateValidator : AbstractValidator<OrderCreateDto>
{
    public OrderCreateValidator()
    {

    }
}
