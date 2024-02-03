using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.CategoryDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class CategoryManager : ServiceManager<CategoryCreateDto, CategoryUpdateDto, CategoryListDto, Category>, ICategoryService
{
    public CategoryManager(IMapper mapper, IValidator<CategoryCreateDto> createValidator, IValidator<CategoryUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
