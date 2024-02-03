using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.ContactDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class ContactManager : ServiceManager<ContactCreateDto, ContactUpdateDto, ContactListDto, Contact>, IContactService
{
    public ContactManager(IMapper mapper, IValidator<ContactCreateDto> createValidator, IValidator<ContactUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
