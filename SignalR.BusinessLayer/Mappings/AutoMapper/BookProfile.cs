using AutoMapper;
using SignalR.DtoLayer.BookingDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Mappings.AutoMapper;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Booking, BookingCreateDto>().ReverseMap();
        CreateMap<Booking, BookingListDto>().ReverseMap();
        CreateMap<Booking, BookingUpdateDto>().ReverseMap();
    }
}
