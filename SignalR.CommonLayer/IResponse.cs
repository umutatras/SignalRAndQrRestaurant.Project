using SignalR.CommonLayer.Enums;

namespace SignalR.CommonLayer;

public interface IResponse
{
    string Message { get; set; }
    ResponseType ResponseType { get; set; }
}
