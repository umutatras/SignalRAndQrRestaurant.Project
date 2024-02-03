using SignalR.DtoLayer.ContactDtos;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer.Interfaces;

public interface IContactService : IService<ContactCreateDto, ContactUpdateDto, ContactListDto, Contact>
{
}
