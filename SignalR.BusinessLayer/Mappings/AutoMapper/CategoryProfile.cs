using AutoMapper;
using SignalR.DtoLayer.CategoryDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category,CategoryCreateDto>().ReverseMap();
        CreateMap<Category,CategoryListDto>().ReverseMap();
        CreateMap<Category,CategoryUpdateDto>().ReverseMap();

    }
}
