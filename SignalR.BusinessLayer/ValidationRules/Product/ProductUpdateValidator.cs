using FluentValidation;
using SignalR.DtoLayer.ProductDtos;

namespace SignalR.BusinessLayer.ValidationRules.Product;

public class ProductUpdateValidator : AbstractValidator<ProductUpdateDto>
{
    public ProductUpdateValidator()
    {
    }
}
