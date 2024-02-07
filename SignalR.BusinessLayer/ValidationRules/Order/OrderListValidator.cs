using FluentValidation;
using SignalR.DtoLayer.Order;

namespace SignalR.BusinessLayer.ValidationRules.Order;

public class OrderListValidator : AbstractValidator<OrderListDto>
{
    public OrderListValidator()
    {

    }
}
