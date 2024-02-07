using SignalR.DtoLayer.CategoryDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface ICategoryService : IService<CategoryCreateDto, CategoryUpdateDto, CategoryListDto, Category>
{
    int Categorycount();
    int EnabledCategoryCount();
    int DisabledCategoryCount();
}
