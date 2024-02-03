using FluentValidation;
using SignalR.DtoLayer.CategoryDtos;

namespace SignalR.BusinessLayer.ValidationRules.Category;

public class CategoryCreateValidator : AbstractValidator<CategoryCreateDto>
{
    public CategoryCreateValidator()
    {
    }
}
