using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.ProductDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public async Task<IResponse<List<ProductListDto>>> GetProductList()
    {
        var result = await _productService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public int ProductCount()
    {
        var result = _productService.ProductCount();
        return result;
    }
    [HttpGet]
    public decimal ProductPriveAvg()
    {
        var result = _productService.ProductPriveAvg();
        return result;
    } 
    [HttpGet]
    public decimal ProductPriceByHamburger()
    {
        var result = _productService.ProductPriceByHamburger();
        return result;
    }
    [HttpGet]
    public string ProductNameMinPrice()
    {
        var result = _productService.ProductNameMinPrice();
        return result;
    }
    [HttpGet]
    public string ProductNameMaxPrice()
    {
        var result = _productService.ProductNameMaxPrice();
        return result;
    }
    [HttpGet]
    public int ProductCountByCategoryNameHamburger()
    {
        var result = _productService.ProductCountByCategoryNameHamburger();
        return result;
    }
    [HttpGet]
    public int ProductCountByCategoryNameDrink()
    {
        var result = _productService.ProductCountByCategoryNameDrink();
        return result;
    }
    [HttpGet]
    public async Task<List<ProductListWithCategoryDto>> GetProductListWithCategory()
    {
        var result = await _productService.GetProductListWithCategory();
        return result;
    }
    [HttpGet]
    public async Task<ProductListWithCategoryDto> SingleGetProductListWithCategory(int id)
    {
        var result = await _productService.SingleGetProductListWithCategory(id);
        return result;
    }
    [HttpGet]
    public async Task<IResponse<ProductListDto>> GetById(int id)
    {
        var result = await _productService.GetByIdAsync<ProductListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<ProductCreateDto>> Add(ProductCreateDto dto)
    {
        var result = await _productService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<ProductUpdateDto>> Update(ProductUpdateDto dto)
    {
        var result = await _productService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _productService.RemoveAsync(id);
        return result;
    }
}
