using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DtoLayer.CategoryDtos;

namespace SignalR.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet]
    public async Task<IResponse<List<CategoryListDto>>> GetCategoryList()
    {
        var result = await _categoryService.GetAllAsync();
        return result;
    }
    [HttpGet]
    public async Task<IResponse<CategoryListDto>> GetById(int id)
    {
        var result = await _categoryService.GetByIdAsync<CategoryListDto>(id);
        return result;
    }
    [HttpPost]
    public async Task<IResponse<CategoryCreateDto>> Add(CategoryCreateDto dto)
    {
        var result = await _categoryService.CreateAsync(dto);
        return result;
    }
    [HttpPut]
    public async Task<IResponse<CategoryUpdateDto>> Update(CategoryUpdateDto dto)
    {
        var result = await _categoryService.UpdateAsync(dto);
        return result;
    }
    [HttpDelete]
    public async Task<IResponse> Remove(int id)
    {
        var result = await _categoryService.RemoveAsync(id);
        return result;
    }
}
