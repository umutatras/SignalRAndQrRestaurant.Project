using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Configuration;
using SignalR.EntityLayer;
using SignalR.EntityLayer.Entities;
using System.Reflection;

namespace SignalR.DataAccessLayer.Concrete;

public class RestaurantContext:DbContext
{
    public RestaurantContext(DbContextOptions<RestaurantContext> options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AboutConfiguration)));
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<MoneyCase> MoneyCases { get; set; }
    public DbSet<Desk> Desks { get; set; }
}
