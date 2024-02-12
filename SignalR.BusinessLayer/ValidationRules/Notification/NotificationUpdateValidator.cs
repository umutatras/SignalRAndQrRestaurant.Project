using FluentValidation;
using SignalR.DtoLayer.Nofitication;

namespace SignalR.BusinessLayer.ValidationRules.Notification;

public class NotificationUpdateValidator : AbstractValidator<NofiticationUpdateDto>
{
    public NotificationUpdateValidator()
    {

    }
}
