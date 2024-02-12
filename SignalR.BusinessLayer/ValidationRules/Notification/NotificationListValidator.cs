using FluentValidation;
using SignalR.DtoLayer.Nofitication;

namespace SignalR.BusinessLayer.ValidationRules.Notification;

public class NotificationListValidator:AbstractValidator<NofiticationListDto>
{
    public NotificationListValidator()
    {
        
    }
}
