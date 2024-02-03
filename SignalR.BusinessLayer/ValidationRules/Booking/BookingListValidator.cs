using FluentValidation;
using SignalR.DtoLayer.BookingDtos;

namespace SignalR.BusinessLayer.ValidationRules.Booking;

public class BookingListValidator : AbstractValidator<BookingListDto>
{
    public BookingListValidator()
    {
    }
}
