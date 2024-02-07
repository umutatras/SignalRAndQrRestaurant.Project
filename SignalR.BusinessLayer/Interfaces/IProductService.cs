using SignalR.CommonLayer;
using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IProductService : IService<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>
{
    Task<List<ProductListWithCategoryDto>> GetProductListWithCategory();
    Task<ProductListWithCategoryDto> SingleGetProductListWithCategory(int id);
    int ProductCount();
    int ProductCountByCategoryNameDrink();
    int ProductCountByCategoryNameHamburger();

    decimal ProductPriveAvg();
    string ProductNameMinPrice();
    string ProductNameMaxPrice();
    decimal ProductPriceByHamburger();
}
