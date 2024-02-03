using FluentValidation;
using SignalR.DtoLayer.ProductDtos;

namespace SignalR.BusinessLayer.ValidationRules.Product;

public class ProductCreateValidator : AbstractValidator<ProductCreateDto>
{
    public ProductCreateValidator()
    {
    }
}
