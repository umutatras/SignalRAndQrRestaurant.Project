using FluentValidation;
using SignalR.DtoLayer.ContactDtos;

namespace SignalR.BusinessLayer.ValidationRules.Contact;

public class ContactCreateValidator : AbstractValidator<ContactCreateDto>
{
    public ContactCreateValidator()
    {
    }
}
