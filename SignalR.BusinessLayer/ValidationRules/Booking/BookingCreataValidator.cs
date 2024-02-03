using FluentValidation;
using SignalR.DtoLayer.BookingDtos;

namespace SignalR.BusinessLayer.ValidationRules.Booking;

public class BookingCreataValidator : AbstractValidator<BookingCreateDto>
{
    public BookingCreataValidator()
    {
    }
}
