using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.CategoryDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class CategoryManager : ServiceManager<CategoryCreateDto, CategoryUpdateDto, CategoryListDto, Category>, ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    public CategoryManager(IMapper mapper, IValidator<CategoryCreateDto> createValidator, IValidator<CategoryUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public int Categorycount()
    {
        var result = _unitOfWork.GetRepository<Category>().Query().Count();
        return result;
    }

    public int DisabledCategoryCount()
    {
        var result = _unitOfWork.GetRepository<Category>().Query().Where(f=>f.Status==false).Count();
        return result;
    }

    public int EnabledCategoryCount()
    {
        var result = _unitOfWork.GetRepository<Category>().Query().Where(f=>f.Status==true).Count();
        return result;
    }
}
