using FluentValidation;
using SignalR.DtoLayer.DeskDtos;

namespace SignalR.BusinessLayer.ValidationRules.Desk;

public class DeskListValidator : AbstractValidator<DeskListDto>
{
    public DeskListValidator()
    {

    }
}
