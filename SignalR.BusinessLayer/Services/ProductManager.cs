using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class ProductManager : ServiceManager<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
{
    public ProductManager(IMapper mapper, IValidator<ProductCreateDto> createValidator, IValidator<ProductUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
