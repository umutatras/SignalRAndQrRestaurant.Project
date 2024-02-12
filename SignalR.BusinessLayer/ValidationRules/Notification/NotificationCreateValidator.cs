using FluentValidation;
using SignalR.DtoLayer.Nofitication;

namespace SignalR.BusinessLayer.ValidationRules.Notification;

public class NotificationCreateValidator : AbstractValidator<NotificationCreateDto>
{
    public NotificationCreateValidator()
    {

    }
}
