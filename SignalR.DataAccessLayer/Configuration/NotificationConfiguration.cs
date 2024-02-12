using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Configuration;

public class NotificationConfiguration : IEntityTypeConfiguration<Nofitication>
{
    public void Configure(EntityTypeBuilder<Nofitication> builder)
    {
        builder.HasIndex(e => e.Id);
    }
}
