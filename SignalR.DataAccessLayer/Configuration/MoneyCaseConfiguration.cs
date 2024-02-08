using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Configuration;

public class MoneyCaseConfiguration : IEntityTypeConfiguration<MoneyCase>
{
    public void Configure(EntityTypeBuilder<MoneyCase> builder)
    {
        builder.HasIndex(e => e.Id);
    }
}
