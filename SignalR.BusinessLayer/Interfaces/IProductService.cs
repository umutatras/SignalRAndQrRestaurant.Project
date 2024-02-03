using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IProductService : IService<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>
{
}
