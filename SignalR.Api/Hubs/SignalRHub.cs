using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Interfaces;

namespace SignalR.Api.Hubs;

public class SignalRHub : Hub
{
    private readonly ICategoryService _categoryService;

    public SignalRHub(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task SendCategoryCount()
    {
        var value=_categoryService.GetAllAsync();
        var count=value.Result.Data.Count;
        await Clients.All.SendAsync("ReceiveCategoryCount",count);
    }
}
