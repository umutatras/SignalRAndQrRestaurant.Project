using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Interfaces;
using SignalR.CommonLayer;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class ProductManager : ServiceManager<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
{
    private IMapper _mapper;
    private IUnitOfWork _unitOfWork;
    public ProductManager(IMapper mapper, IValidator<ProductCreateDto> createValidator, IValidator<ProductUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _mapper=mapper;
    }

    public async Task<List<ProductListWithCategoryDto>> GetProductListWithCategory()
    {
        var data=await _unitOfWork.GetRepository<Product>().Query()
            .Include(i=>i.Category)
            .ToListAsync();
        var result= _mapper.Map<List<ProductListWithCategoryDto>>(data);
        return result;
    }
}
