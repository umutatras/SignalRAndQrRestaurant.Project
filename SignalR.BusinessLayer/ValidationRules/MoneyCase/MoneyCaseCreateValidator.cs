using FluentValidation;
using SignalR.DtoLayer.MoneyCase;

namespace SignalR.BusinessLayer.ValidationRules.MoneyCase;

public class MoneyCaseCreateValidator:AbstractValidator<MoneyCaseCreateDto>
{
    public MoneyCaseCreateValidator()
    {
        
    }
}
