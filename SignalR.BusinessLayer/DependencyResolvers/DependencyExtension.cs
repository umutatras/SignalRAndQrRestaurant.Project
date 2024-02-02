using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.BusinessLayer.Helpers;
using SignalR.BusinessLayer.Interfaces;
using SignalR.BusinessLayer.Services;
using SignalR.BusinessLayer.ValidationRules;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.UnitOfWork;
using SignalR.DtoLayer.AbotDtos;

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
 

        services.AddScoped<IAboutService, AboutManager>();
        var profiles = ProfileHelper.GetProfiles();
        var configurationMapper = new MapperConfiguration(opt =>
        {
            opt.AddProfiles(profiles);
        });
        var mapper = configurationMapper.CreateMapper();
        services.AddSingleton(mapper);

    }
}
