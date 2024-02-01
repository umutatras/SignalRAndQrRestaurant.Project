using FluentValidation.Results;
using SignalR.CommonLayer;

namespace SignalR.BusinessLayer.Extensions;

public static class ValidationResultExtension
{
    public static List<CustomValidationError> ConvertToCustomValdiatonError(this ValidationResult validationResult)
    {
        List<CustomValidationError> errors = new();
        foreach (var item in validationResult.Errors)
        {
            errors.Add(new()
            {
                ErrorMessage = item.ErrorMessage,
                PropertyName = item.PropertyName
            });

        }
        return errors;

    }
}
