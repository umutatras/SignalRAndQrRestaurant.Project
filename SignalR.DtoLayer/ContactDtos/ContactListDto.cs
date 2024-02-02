using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.ContactDtos;

public class ContactListDto : IDto
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
