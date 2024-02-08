using FluentValidation;
using SignalR.DtoLayer.DeskDtos;

namespace SignalR.BusinessLayer.ValidationRules.Desk;

public class DeskUpdateValidator : AbstractValidator<DeskUpdateDto>
{
    public DeskUpdateValidator()
    {

    }
}
