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
    public async Task<IResponse<List<ProductListDto>>> GetAboutList()
    {
        var result = await _productService.GetAllAsync();
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
