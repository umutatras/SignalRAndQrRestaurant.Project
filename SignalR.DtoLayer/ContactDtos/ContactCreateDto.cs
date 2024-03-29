﻿using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.ContactDtos;

public class ContactCreateDto : IDto
{
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
