using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Interfaces;

namespace SignalR.Api.Hubs;

public class SignalRHub : Hub
{
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    private readonly IOrderService _orderService;
    private readonly IMoneyCaseService _moneyCaseService;
    private readonly IDeskService _deskService;
    private readonly IBookingService _bookingService;
    private readonly INotificationService _notify;
    public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IDeskService deskService, IBookingService bookingService, INotificationService notify)
    {
        _categoryService = categoryService;
        _productService = productService;
        _orderService = orderService;
        _moneyCaseService = moneyCaseService;
        _deskService = deskService;
        _bookingService = bookingService;
        _notify = notify;
    }

    public async Task SendCategoryCount()
    {
        var value=_categoryService.GetAllAsync();
        var count=value.Result.Data.Count;
        await Clients.All.SendAsync("ReceiveCategoryCount",count);
    }
    public async Task SendProductCount()
    {
        var value = _productService.GetAllAsync();
        var count = value.Result.Data.Count;
        await Clients.All.SendAsync("ReceiveProductCount", count);
    }
    public async Task SendActiveCategoryCount()
    {
        var count = _categoryService.EnabledCategoryCount();
     
        await Clients.All.SendAsync("ReceiveActiveCategoryCount", count);
    }
    public async Task SendPassiveCategoryCount()
    {
        var count = _categoryService.DisabledCategoryCount();

        await Clients.All.SendAsync("ReceivePassiveCategoryCount", count);
    }
    public async Task SendProductByCategoryName()
    {
        try
        {
            var count1 = _productService.ProductCountByCategoryNameHamburger();
            var count2 = _productService.ProductCountByCategoryNameDrink();
            var count3 = _productService.ProductPriveAvg();
            var count4 = _productService.ProductNameMaxPrice();
            var count5 = _productService.ProductNameMinPrice();
            var count6 = _productService.ProductPriceByHamburger();
            var value = _orderService.TotalOrderCount();
            var value2 = _orderService.TodayTotalPrice();
            var value3=_orderService.ActiveOrderCount();
            var value4=_orderService.EndOrderPrice();
            var value5= _moneyCaseService.TotalMoneyCaseAmount();
            var value6= _deskService.MenuTableCount();
            await Clients.All.SendAsync("ReceiveProductByCategoryNameHamburger", count1);
            await Clients.All.SendAsync("ReceiveProductByCategoryNameDrink", count2);
            await Clients.All.SendAsync("ReceiveProductAvgPrice", count3);
            await Clients.All.SendAsync("ReceiveProductNameMaxPrice", count4);
            await Clients.All.SendAsync("ReceiveProductNameMinPrice", count5);
            await Clients.All.SendAsync("ReceiveProductPriceByHamburger", count6);
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value);
            await Clients.All.SendAsync("ReceiveTodayTotalPrice", value2);
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value3);
            await Clients.All.SendAsync("ReceiveEndOrderPrice", value4);
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value5);
            await Clients.All.SendAsync("ReceiveMenuTableCount", value6);

        }
        catch (Exception)
        {

            throw;
        }
    
    }
    public async Task SendProgress()
    {
        var count = _moneyCaseService.TotalMoneyCaseAmount();
        var value=_orderService.ActiveOrderCount();
        var value2 = _deskService.MenuTableCount();

        await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", count);
        await Clients.All.SendAsync("ReceiveActiveOrderCount", value);
        await Clients.All.SendAsync("ReceiveMenuTableCount", value2);
    }
    public async Task GetBookingList()
    {
        var values=await _bookingService.GetAllAsync();
        await Clients.All.SendAsync("ReceiveBookingList", values.Data);
    }

    public async Task SendNotification()
    {
        var value=_notify.NotificationCountByStatusFalse();
        await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", value);

        var notify = _notify.GetAllNotifyByFalse();
        await Clients.All.SendAsync("ReceiveGetAllNotifyByFalse", notify);
    }

}
