namespace SignalR.WebUI.Dtos;

public class ResponseDto<T>
{
    public T Data { get; set; }
    public object ValidationErrors { get; set; }
    public object Message { get; set; }
    public int ResponseType { get; set; }
}
