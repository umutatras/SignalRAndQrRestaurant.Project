using FluentValidation;
using SignalR.DtoLayer.ProductDtos;

namespace SignalR.BusinessLayer.ValidationRules.Product;

public class ProductListValidator : AbstractValidator<ProductListDto>
{
    public ProductListValidator()
    {
    }
}
