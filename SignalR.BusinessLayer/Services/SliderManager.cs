using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.SliderDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class SliderManager : ServiceManager<SliderCreateDto, SliderUpdateDto, SliderListDto, Slider>, ISliderService
{
    public SliderManager(IMapper mapper, IValidator<SliderCreateDto> createValidator, IValidator<SliderUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
