using FluentValidation;
using SignalR.DtoLayer.OrderDetail;

namespace SignalR.BusinessLayer.ValidationRules.OrderDetail;
public class OrderDetailListValidator : AbstractValidator<OrderDetailListDto>
{
    public OrderDetailListValidator()
    {

    }
}
