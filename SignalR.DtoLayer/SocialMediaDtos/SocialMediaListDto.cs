﻿using SignalR.DtoLayer.Interfaces;

namespace SignalR.DtoLayer.SocialMediaDtos;

public class SocialMediaListDto : IDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
