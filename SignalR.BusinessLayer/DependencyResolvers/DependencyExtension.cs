using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.BusinessLayer.Helpers;
using SignalR.BusinessLayer.Interfaces;
using SignalR.BusinessLayer.Services;
using SignalR.BusinessLayer.ValidationRules.About;
using SignalR.BusinessLayer.ValidationRules.Basket;
using SignalR.BusinessLayer.ValidationRules.Booking;
using SignalR.BusinessLayer.ValidationRules.Category;
using SignalR.BusinessLayer.ValidationRules.Contact;
using SignalR.BusinessLayer.ValidationRules.Desk;
using SignalR.BusinessLayer.ValidationRules.Discount;
using SignalR.BusinessLayer.ValidationRules.Feature;
using SignalR.BusinessLayer.ValidationRules.MoneyCase;
using SignalR.BusinessLayer.ValidationRules.Notification;
using SignalR.BusinessLayer.ValidationRules.Order;
using SignalR.BusinessLayer.ValidationRules.OrderDetail;
using SignalR.BusinessLayer.ValidationRules.Product;
using SignalR.BusinessLayer.ValidationRules.Slider;
using SignalR.BusinessLayer.ValidationRules.SocialMedia;
using SignalR.BusinessLayer.ValidationRules.Testimonial;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.AbotDtos;
using SignalR.DtoLayer.BasketDtos;
using SignalR.DtoLayer.BookingDtos;
using SignalR.DtoLayer.CategoryDtos;
using SignalR.DtoLayer.ContactDtos;
using SignalR.DtoLayer.DeskDtos;
using SignalR.DtoLayer.DiscountDtos;
using SignalR.DtoLayer.FeatureDtos;
using SignalR.DtoLayer.MoneyCase;
using SignalR.DtoLayer.Nofitication;
using SignalR.DtoLayer.Order;
using SignalR.DtoLayer.OrderDetail;
using SignalR.DtoLayer.ProductDtos;
using SignalR.DtoLayer.SliderDtos;
using SignalR.DtoLayer.SocialMediaDtos;
using SignalR.DtoLayer.TestimonialDtos;

namespace SignalR.BusinessLayer.DependencyResolvers;

public static class DependencyExtension
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RestaurantContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("SqlServer"));

        });

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddTransient<IValidator<AboutCreateDto>, AboutCreateValidator>();
        services.AddTransient<IValidator<AboutListDto>, AboutListValidator>();
        services.AddTransient<IValidator<AboutUpdateDto>, AboutUpdateValidator>();

        services.AddTransient<IValidator<BookingCreateDto>, BookingCreataValidator>();
        services.AddTransient<IValidator<BookingListDto>, BookingListValidator>();
        services.AddTransient<IValidator<BookingUpdateDto>, BookingUpdateValidator>();

        services.AddTransient<IValidator<CategoryCreateDto>, CategoryCreateValidator>();
        services.AddTransient<IValidator<CategoryListDto>, CategoryListValidator>();
        services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();

        services.AddTransient<IValidator<ContactCreateDto>, ContactCreateValidator>();
        services.AddTransient<IValidator<ContactListDto>, ContactListValidator>();
        services.AddTransient<IValidator<ContactUpdateDto>, ContactUpdateValidator>();

        services.AddTransient<IValidator<DiscountCreateDto>, DiscountCreateValidator>();
        services.AddTransient<IValidator<DiscountListDto>, DiscountListValidator>();
        services.AddTransient<IValidator<DiscountUpdateDto>, DiscountUpdateValidator>();

        services.AddTransient<IValidator<FeatureCreateDto>, FeatureCreateValidator>();
        services.AddTransient<IValidator<FeatureListDto>, FeatureListValidator>();
        services.AddTransient<IValidator<FeatureUpdateDto>, FeatureUpdateValidator>();

        services.AddTransient<IValidator<ProductCreateDto>, ProductCreateValidator>();
        services.AddTransient<IValidator<ProductListDto>, ProductListValidator>();
        services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateValidator>();

        services.AddTransient<IValidator<SocialMediaCreateDto>, SocialMediaCreateValidator>();
        services.AddTransient<IValidator<SocialMediaListDto>, SocialMediaListValidator>();
        services.AddTransient<IValidator<SocialMediaUpdateDto>, SocialMediaUpdateValidator>();

        services.AddTransient<IValidator<TestimonialCreateDto>, TestimonialCreateValidator>();
        services.AddTransient<IValidator<TestimonialListDto>, TestimonialListValidator>();
        services.AddTransient<IValidator<TestimonialUpdateDto>, TestimonialUpdateValidator>();

        services.AddTransient<IValidator<OrderCreateDto>, OrderCreateValidator>();
        services.AddTransient<IValidator<OrderListDto>, OrderListValidator>();
        services.AddTransient<IValidator<OrderUpdateDto>, OrderUpdateValidator>();

        services.AddTransient<IValidator<OrderDetailCreateDto>, OrderDetailCreateValidator>();
        services.AddTransient<IValidator<OrderDetailListDto>, OrderDetailListValidator>();
        services.AddTransient<IValidator<OrderDetailUpdateDto>, OrderDetailUpdateValidator>();

        services.AddTransient<IValidator<MoneyCaseCreateDto>, MoneyCaseCreateValidator>();
        services.AddTransient<IValidator<MoneyCaseListDto>, MoneyCaseListValidator>();
        services.AddTransient<IValidator<MoneyCaseUpdateDto>, MoneyCaseUpdateValidator>();

        services.AddTransient<IValidator<DeskCreateDto>, DeskCreateValidator>();
        services.AddTransient<IValidator<DeskListDto>, DeskListValidator>();
        services.AddTransient<IValidator<DeskUpdateDto>, DeskUpdateValidator>();

        services.AddTransient<IValidator<SliderCreateDto>, SliderCreateValidator>();
        services.AddTransient<IValidator<SliderListDto>, SliderListValidator>();
        services.AddTransient<IValidator<SliderUpdateDto>, SliderUpdateValidator>();

        services.AddTransient<IValidator<BasketCreateDto>, BasketCreateValidator>();
        services.AddTransient<IValidator<BasketListDto>, BasketListValidator>();
        services.AddTransient<IValidator<BasketUpdateDto>, BasketUpdateValidator>();

        services.AddTransient<IValidator<NotificationCreateDto>, NotificationCreateValidator>();
        services.AddTransient<IValidator<NofiticationListDto>, NotificationListValidator>();
        services.AddTransient<IValidator<NofiticationUpdateDto>, NotificationUpdateValidator>();

        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IBookingService, BookingManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IDiscountService, DiscountManager>();
        services.AddScoped<IFeatureService, FeatureManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
        services.AddScoped<IOrderService, OrderManager>();
        services.AddScoped<IOrderDetailService, OrderDetailManager>();
        services.AddScoped<IMoneyCaseService, MoneyCaseManager>();
        services.AddScoped<IDeskService, DeskManager>();
        services.AddScoped<ISliderService, SliderManager>();
        services.AddScoped<IBasketService, BasketManager>();
        services.AddScoped<INotificationService, NotificationManager>();


        var profiles = ProfileHelper.GetProfiles();
        var configurationMapper = new MapperConfiguration(opt =>
        {
            opt.AddProfiles(profiles);
        });
        var mapper = configurationMapper.CreateMapper();
        services.AddSingleton(mapper);

    }
}
