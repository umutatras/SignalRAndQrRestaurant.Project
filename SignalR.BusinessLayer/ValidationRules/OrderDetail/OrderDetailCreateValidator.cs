using FluentValidation;
using SignalR.DtoLayer.OrderDetail;

namespace SignalR.BusinessLayer.ValidationRules.OrderDetail;
public class OrderDetailCreateValidator : AbstractValidator<OrderDetailCreateDto>
{
    public OrderDetailCreateValidator()
    {

    }
}
