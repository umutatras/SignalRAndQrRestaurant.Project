using FluentValidation;
using SignalR.DtoLayer.CategoryDtos;

namespace SignalR.BusinessLayer.ValidationRules.Category
{
    public class CategoryListValidator : AbstractValidator<CategoryListDto>
    {
        public CategoryListValidator()
        {
        }
    }
}
