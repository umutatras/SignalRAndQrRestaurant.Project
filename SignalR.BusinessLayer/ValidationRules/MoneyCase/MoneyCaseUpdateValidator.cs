using FluentValidation;
using SignalR.DtoLayer.MoneyCase;

namespace SignalR.BusinessLayer.ValidationRules.MoneyCase;

public class MoneyCaseUpdateValidator:AbstractValidator<MoneyCaseUpdateDto>
{
    public MoneyCaseUpdateValidator()
    {
        
    }
}
