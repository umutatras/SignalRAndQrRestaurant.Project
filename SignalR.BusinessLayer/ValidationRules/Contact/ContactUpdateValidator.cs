using FluentValidation;
using SignalR.DtoLayer.ContactDtos;

namespace SignalR.BusinessLayer.ValidationRules.Contact;

public class ContactUpdateValidator : AbstractValidator<ContactUpdateDto>
{
    public ContactUpdateValidator()
    {
    }
}
