using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Configuration;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasIndex(e => e.Id);
        builder.HasOne(e => e.Desk).WithMany(e => e.Basket).HasForeignKey(e => e.DeskId);
        builder.HasOne(e => e.Product).WithMany(e => e.Baskets).HasForeignKey(e => e.ProductId);
    }
}
