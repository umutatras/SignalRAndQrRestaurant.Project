﻿namespace SignalR.EntityLayer;

public class Booking
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime CreateDate { get; set; }
}
