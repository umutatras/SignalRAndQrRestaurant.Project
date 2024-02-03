using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.SocialMediaDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Services;

public class SocialMediaManager : ServiceManager<SocialMediaCreateDto, SocialMediaUpdateDto, SocialMediaListDto, SocialMedia>, ISocialMediaService
{
    public SocialMediaManager(IMapper mapper, IValidator<SocialMediaCreateDto> createValidator, IValidator<SocialMediaUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
