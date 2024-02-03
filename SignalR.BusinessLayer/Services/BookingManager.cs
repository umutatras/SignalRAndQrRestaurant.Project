using AutoMapper;
using FluentValidation;
using SignalR.BusinessLayer.Interfaces;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.BookingDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Services;

public class BookingManager : ServiceManager<BookingCreateDto, BookingUpdateDto, BookingListDto, Booking>, IBookingService
{
    public BookingManager(IMapper mapper, IValidator<BookingCreateDto> createValidator, IValidator<BookingUpdateDto> updateValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, unitOfWork)
    {
    }
}
