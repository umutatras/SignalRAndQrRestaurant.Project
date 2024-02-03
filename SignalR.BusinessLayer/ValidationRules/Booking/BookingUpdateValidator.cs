using FluentValidation;
using SignalR.DtoLayer.BookingDtos;

namespace SignalR.BusinessLayer.ValidationRules.Booking
{
    public class BookingUpdateValidator : AbstractValidator<BookingUpdateDto>
    {
        public BookingUpdateValidator()
        {
        }
    }
}
