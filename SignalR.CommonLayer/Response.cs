﻿using SignalR.CommonLayer.Enums;

namespace SignalR.CommonLayer;

public class Response : IResponse
{
    public Response(ResponseType responseType)
    {
        ResponseType = responseType;
    }

    public Response(ResponseType responseType, string messsage)
    {
        ResponseType = responseType;
        Message = messsage;
    }

    public string Message { get; set; }

    public ResponseType ResponseType { get; set; }
}
