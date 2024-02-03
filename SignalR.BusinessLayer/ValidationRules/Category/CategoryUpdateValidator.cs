using FluentValidation;
using SignalR.DtoLayer.CategoryDtos;

namespace SignalR.BusinessLayer.ValidationRules.Category;

public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateDto>
{
    public CategoryUpdateValidator()
    {
    }
}
