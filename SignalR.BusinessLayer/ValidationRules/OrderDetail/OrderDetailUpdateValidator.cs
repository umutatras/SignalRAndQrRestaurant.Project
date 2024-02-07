using FluentValidation;
using SignalR.DtoLayer.OrderDetail;

namespace SignalR.BusinessLayer.ValidationRules.OrderDetail;

public class OrderDetailUpdateValidator : AbstractValidator<OrderDetailUpdateDto>
{
    public OrderDetailUpdateValidator()
    {

    }
}
