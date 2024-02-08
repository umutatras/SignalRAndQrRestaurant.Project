using FluentValidation;
using SignalR.DtoLayer.DeskDtos;

namespace SignalR.BusinessLayer.ValidationRules.Desk;

public class DeskCreateValidator : AbstractValidator<DeskCreateDto>
{
    public DeskCreateValidator()
    {

    }
}
