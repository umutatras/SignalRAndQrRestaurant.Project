namespace SignalR.WebUI.Dtos;

public class NotificationUpdateDto
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
