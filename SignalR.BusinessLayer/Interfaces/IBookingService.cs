using SignalR.DtoLayer.BookingDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IBookingService : IService<BookingCreateDto, BookingUpdateDto, BookingListDto, Booking>
{
}
