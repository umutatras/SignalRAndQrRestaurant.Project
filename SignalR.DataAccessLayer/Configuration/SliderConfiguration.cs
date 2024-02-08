using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Configuration;

public class SliderConfiguration : IEntityTypeConfiguration<Slider>
{
    public void Configure(EntityTypeBuilder<Slider> builder)
    {
        builder.HasIndex(e => e.Id);
    }
}
