using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasIndex(e => e.Id);
        builder.HasMany(e=>e.OrderDetails).WithOne(e=>e.Order).HasForeignKey(e=>e.OrderId);
    }
}
