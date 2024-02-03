using FluentValidation;
using SignalR.DtoLayer.ContactDtos;

namespace SignalR.BusinessLayer.ValidationRules.Contact;

public class ContactListValidator : AbstractValidator<ContactListDto>
{
    public ContactListValidator()
    {
    }
}
