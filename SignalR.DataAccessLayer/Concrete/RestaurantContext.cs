using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Concrete;

public class RestaurantContext:DbContext
{
    public RestaurantContext(DbContextOptions<RestaurantContext> options):base(options)
    {
        
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
}
