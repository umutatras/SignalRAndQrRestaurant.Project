using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SignalR.Api.Hubs;
using SignalR.BusinessLayer.DependencyResolvers;
using SignalR.DataAccessLayer.Concrete;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependencies(builder.Configuration);
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.AllowAnyMethod()
        .AllowCredentials()        
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true)));
builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.MapHub<SignalRHub>("/signalrhub");
app.UseHangfireDashboard("/hangfire");
app.UseHangfireServer();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
