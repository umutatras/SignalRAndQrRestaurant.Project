﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer.Configuration;

public class BookingConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.HasIndex(e => e.Id);
    }
}
