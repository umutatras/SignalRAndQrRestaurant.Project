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

    public int ProductCount()
    {
        var result=_unitOfWork.GetRepository<Product>().Query().Count();
        return result;
    }

    public int ProductCountByCategoryNameDrink()
    {
        var result = _unitOfWork.GetRepository<Product>()
            .Query()
            .Where(f=>f.CategoryId==(_unitOfWork.GetRepository<Category>().Query().Where(y=>y.Name=="İçecek").Select(s=>s.Id).FirstOrDefault()))
            .Count();
        return result;
    }

    public int ProductCountByCategoryNameHamburger()
    {
        var result = _unitOfWork.GetRepository<Product>()
            .Query()
            .Where(f => f.CategoryId == (_unitOfWork.GetRepository<Category>().Query().Where(y => y.Name == "Hamburger").Select(s => s.Id).FirstOrDefault()))
            .Count();
        return result;
    }

    public string ProductNameMaxPrice()
    {
        var result = _unitOfWork.GetRepository<Product>()
           .Query()
           .Where(x => x.Price == (_unitOfWork.GetRepository<Product>()
           .Query().Max(m => m.Price)))
           .Select(x => x.Name)
           .FirstOrDefault() ;
        return result;
    }

    public string ProductNameMinPrice()
    {
        var result = _unitOfWork.GetRepository<Product>()
           .Query()
           .Where(x => x.Price == (_unitOfWork.GetRepository<Product>()
           .Query().Min(m => m.Price)))
           .Select(x => x.Name)
           .FirstOrDefault();
        return result;
    }

    public decimal ProductPriceByHamburger()
    {
        var result = _unitOfWork.GetRepository<Product>()
            .Query()
            .Where(f => f.CategoryId == (_unitOfWork.GetRepository<Category>().Query().Where(y => y.Name == "İçecek").Select(s => s.Id).FirstOrDefault()))
            .Average(a=>a.Price);
        return result;
    }

    public decimal ProductPriveAvg()
    {
        var result = _unitOfWork.GetRepository<Product>().Query().Average(a=>a.Price);
        return result;
    }

    public async Task<ProductListWithCategoryDto> SingleGetProductListWithCategory(int id)
    {
        var data = await _unitOfWork.GetRepository<Product>().Query()
            .Where(x=>x.Id==id)
            .Include(i => i.Category)
            .FirstOrDefaultAsync();
        var result = _mapper.Map<ProductListWithCategoryDto>(data);
        return result;
    }
}
