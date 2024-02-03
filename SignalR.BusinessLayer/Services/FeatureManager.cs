using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.FeatureDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class FeatureManager : ServiceManager<FeatureCreateDto, FeatureUpdateDto, FeatureListDto, Feature>, IFeatureService
{
    public FeatureManager(IMapper mapper, IValidator<FeatureCreateDto> createValidator, IValidator<FeatureUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
