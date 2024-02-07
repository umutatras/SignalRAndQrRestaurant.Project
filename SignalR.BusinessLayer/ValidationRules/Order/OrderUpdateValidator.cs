using FluentValidation;
using SignalR.DtoLayer.Order;

namespace SignalR.BusinessLayer.ValidationRules.Order;

public class OrderUpdateValidator : AbstractValidator<OrderUpdateDto>
{
    public OrderUpdateValidator()
    {
        
    }
}
