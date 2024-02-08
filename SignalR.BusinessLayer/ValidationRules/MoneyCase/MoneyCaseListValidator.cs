using FluentValidation;
using SignalR.DtoLayer.MoneyCase;

namespace SignalR.BusinessLayer.ValidationRules.MoneyCase;

public class MoneyCaseListValidator:AbstractValidator<MoneyCaseListDto>
{
    public MoneyCaseListValidator()
    {
        
    }
}
